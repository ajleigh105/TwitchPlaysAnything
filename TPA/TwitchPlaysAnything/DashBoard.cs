using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net.Sockets;

namespace TwitchPlaysAnything
{

    public partial class DashBoard : Form
    {
        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;
        string userName;
        string password;

        public DashBoard()
            
        {
            this.userName = File.ReadAllText("username.txt");
            this.password = File.ReadAllText("password.txt");

            InitializeComponent();
            RefreshControlList();
        }

        //This is how the app connects to the IRC channel and hooks in to the designated Twitch host
        private void Reconnect()
         {
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());

            writer.WriteLine("PASS " + password);
            writer.WriteLine("NICK " + userName);
            writer.WriteLine("USER " + userName + "8 * :" + userName);
            writer.Flush();
            writer.WriteLine("JOIN #" + userName);
            writer.Flush();

        }

        // The Reconnect timer tells the Program when to connect to Twitch using the reconnect function
        void RecconectTimer(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                Reconnect();
            }

            if (tcpClient.Available > 0 || reader.Peek() >= 0)
            {
                var message = reader.ReadLine();
                ChatBox.Text += $"\r\n{message}";
            }
        }


        //This is old code. It will be purged. There will be a great fire. No mercy. Only the strong will survive. The weak will perish in a sea of agony
        private void RefreshControlList()
        {
            ControlsBox.Items.Clear();

            foreach (string control_scheme in Directory.GetFiles("Controls/", "*.ctr", SearchOption.AllDirectories))
            {
                ControlsBox.Items.Add(Path.GetFileNameWithoutExtension(control_scheme));
            }
        }

        private void RunBTN_Click(object sender, EventArgs e)
        {
            if (ReconnectTimer.Enabled == false)
            {
                Reconnect();
                ReconnectTimer.Enabled = true;
                RunBTN.Text = "Stop";
            }

            else
            {
                if (ReconnectTimer.Enabled == true)
                {
                    ReconnectTimer.Enabled = false;
                    ChatBox.AppendText("\n Disconnected");
                    RunBTN.Text = "Run";
                }
            }
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void ControlsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ControlsBox.SelectedIndex == -1)
            {
                RunBTN.Enabled = false;
                EditBTN.Enabled = false;
                CopyBTN.Enabled = false;
                DeleteBTN.Enabled = false;
            }
            else
            {
                RunBTN.Enabled = true;
                EditBTN.Enabled = true;
                CopyBTN.Enabled = true;
                DeleteBTN.Enabled = true;
            }
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            ControlSchemeForm csf = new ControlSchemeForm();
            csf.ShowDialog();
            RefreshControlList();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            ControlSchemeForm csf = new ControlSchemeForm((string)(ControlsBox.GetItemText(ControlsBox.SelectedItem)));
            csf.ShowDialog();
            RefreshControlList();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult DeleteBox = MessageBox.Show("Are you sure you want to delete " + ControlsBox.GetItemText(ControlsBox.SelectedItem) + "?", "Delete?", MessageBoxButtons.YesNo);
            if (DeleteBox == DialogResult.Yes)
            {
                System.IO.File.Delete("Controls/" + ControlsBox.GetItemText(ControlsBox.SelectedItem) + ".ctr");
                RefreshControlList();
            }
            else if (DeleteBox == DialogResult.No)
            {
                //do something else
            }
        }
        private void ReconnectTimer_Tick(object sender, EventArgs e)
        {
            RecconectTimer(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help HelpBox = new Help();
            HelpBox.ShowDialog();
        }

    }
}
