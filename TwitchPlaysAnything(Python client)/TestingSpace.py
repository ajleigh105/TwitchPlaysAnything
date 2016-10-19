s = open("controls.txt")
Lines = s.readlines() 

#x = Lines[0]

for commands in Lines:
    LineSplit = commands.split(':')
    a = LineSplit[0]
    b = LineSplit[1]
    c = LineSplit[2]

print a
print b
print c