using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwitchPlaysAnything
{
    public partial class SettingsForm : Form
    {
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
    }
}
