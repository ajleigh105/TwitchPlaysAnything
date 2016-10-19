#Define the imports
import twitch
import keypresser
import keyholder
t = twitch.Twitch();
k = keypresser.Keypresser();
settings = open("settings.txt")
settingscheck = settings.readlines()
controls = open("controls.txt")
controlscheck = controls.readlines()

#this code checks the settings file to get username and Twitch chat API key
#http://twitchapps.com/tmi/
username = settingscheck[0]
key = settingscheck[1]
t.twitch_connect(username, key);

#The main loop
while True:
    #Check for new mesasages
    new_messages = t.twitch_recieve_messages();
    #If there are no new messages, continue running
    if not new_messages:
        continue
    else:
        try:
            for message in new_messages:
                #Get message details, username + message
                msg = message['message'].lower()
                username = message['username'].lower()
                print(username + ": " + msg);
                #loop through each line of list, check if message matchs "comnd", execute "keybrd" for "time"
                for x in controlscheck:
                    commands = x.split(':')
                    comnd = commands[0]
                    keybrd = commands[1]
                    time = commands[2]
                    if msg == comnd: keyholder.holdForSeconds(keybrd, time);
        #skip errors, Ignores phone emojis mostly
        except:
            continue