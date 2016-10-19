using System;

namespace TwitchPlaysAnything
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RunBTN = new System.Windows.Forms.Button();
            this.ControlsBox = new System.Windows.Forms.ListBox();
            this.NewBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.ChatLabel = new System.Windows.Forms.Label();
            this.ReconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunBTN
            // 
            this.RunBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RunBTN.Enabled = false;
            this.RunBTN.Location = new System.Drawing.Point(91, 314);
            this.RunBTN.Margin = new System.Windows.Forms.Padding(2);
            this.RunBTN.Name = "RunBTN";
            this.RunBTN.Size = new System.Drawing.Size(88, 24);
            this.RunBTN.TabIndex = 0;
            this.RunBTN.Text = "Run";
            this.RunBTN.UseVisualStyleBackColor = true;
            this.RunBTN.Click += new System.EventHandler(this.RunBTN_Click);
            // 
            // ControlsBox
            // 
            this.ControlsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlsBox.FormattingEnabled = true;
            this.ControlsBox.Location = new System.Drawing.Point(9, 34);
            this.ControlsBox.Margin = new System.Windows.Forms.Padding(2);
            this.ControlsBox.Name = "ControlsBox";
            this.ControlsBox.Size = new System.Drawing.Size(251, 277);
            this.ControlsBox.TabIndex = 1;
            this.ControlsBox.SelectedIndexChanged += new System.EventHandler(this.ControlsBox_SelectedIndexChanged);
            // 
            // NewBTN
            // 
            this.NewBTN.Location = new System.Drawing.Point(263, 34);
            this.NewBTN.Margin = new System.Windows.Forms.Padding(2);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(56, 19);
            this.NewBTN.TabIndex = 2;
            this.NewBTN.Text = "New";
            this.NewBTN.UseVisualStyleBackColor = true;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Enabled = false;
            this.EditBTN.Location = new System.Drawing.Point(263, 56);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(2);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(56, 19);
            this.EditBTN.TabIndex = 3;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // CopyBTN
            // 
            this.CopyBTN.Enabled = false;
            this.CopyBTN.Location = new System.Drawing.Point(263, 78);
            this.CopyBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(56, 20);
            this.CopyBTN.TabIndex = 4;
            this.CopyBTN.Text = "Copy";
            this.CopyBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Enabled = false;
            this.DeleteBTN.Location = new System.Drawing.Point(263, 100);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(56, 19);
            this.DeleteBTN.TabIndex = 5;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ChatBox
            // 
            this.ChatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChatBox.Location = new System.Drawing.Point(337, 56);
            this.ChatBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatBox.Size = new System.Drawing.Size(234, 216);
            this.ChatBox.TabIndex = 7;
            this.ChatBox.Text = "";
            // 
            // ChatLabel
            // 
            this.ChatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatLabel.AutoSize = true;
            this.ChatLabel.Location = new System.Drawing.Point(334, 37);
            this.ChatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChatLabel.Name = "ChatLabel";
            this.ChatLabel.Size = new System.Drawing.Size(32, 13);
            this.ChatLabel.TabIndex = 8;
            this.ChatLabel.Text = "Chat:";
            // 
            // ReconnectTimer
            // 
            this.ReconnectTimer.Interval = 400;
            this.ReconnectTimer.Tick += new System.EventHandler(this.ReconnectTimer_Tick);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.ChatLabel);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.NewBTN);
            this.Controls.Add(this.ControlsBox);
            this.Controls.Add(this.RunBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashBoard";
            this.Text = "TPA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button RunBTN;
        private System.Windows.Forms.ListBox ControlsBox;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label ChatLabel;
        public System.Windows.Forms.RichTextBox ChatBox;
        public System.Windows.Forms.Timer ReconnectTimer;
    }
}