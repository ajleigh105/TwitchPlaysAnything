using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TwitchPlaysAnything
{
    public partial class SettingsForm : Form
    {
        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = System.IO.File.ReadAllText("username.txt");
            twitch_ApiTextBox.Text = System.IO.File.ReadAllText("password.txt");
        }

        private void OkayBTN_Click(object sender, EventArgs e)
        {
            string Username = this.userNameTextBox.Text;
            System.IO.File.WriteAllText("username.txt", Username);
            string Password = this.twitch_ApiTextBox.Text;
            System.IO.File.WriteAllText("password.txt", Password);
            this.Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void APILinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitchapps.com/tmi/");
        }

        private void ValidateBTN_Click(object sender, EventArgs e)
        {
            string UserName = this.userNameTextBox.Text;
            string Pass = this.twitch_ApiTextBox.Text;
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());
            writer.WriteLine("PASS " + Pass);
            writer.WriteLine("NICK " + UserName);
            writer.WriteLine("USER " + UserName + "8 * :" + UserName);
            writer.Flush();
            writer.WriteLine("JOIN #" + UserName);
            writer.Flush();

            if (tcpClient.Connected)
            {
                this.ValidateText.ForeColor = System.Drawing.Color.Green;
                this.ValidateText.Text = "Success!";
            }
            if (!tcpClient.Connected)
            {
                this.ValidateText.ForeColor = System.Drawing.Color.Red;
                this.ValidateText.Text = "FAILED!";
            }
        }
    }
}
