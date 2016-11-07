namespace TwitchPlaysAnything
{
    partial class SettingsForm
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.twitch_ApiTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.twitch_APILabel = new System.Windows.Forms.Label();
            this.HintLabel = new System.Windows.Forms.Label();
            this.OkayBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.APILinkLabel = new System.Windows.Forms.LinkLabel();
            this.ValidateBTN = new System.Windows.Forms.Button();
            this.ValidateText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(104, 117);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(336, 26);
            this.userNameTextBox.TabIndex = 0;
            // 
            // twitch_ApiTextBox
            // 
            this.twitch_ApiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twitch_ApiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitch_ApiTextBox.Location = new System.Drawing.Point(104, 164);
            this.twitch_ApiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.twitch_ApiTextBox.Name = "twitch_ApiTextBox";
            this.twitch_ApiTextBox.Size = new System.Drawing.Size(336, 26);
            this.twitch_ApiTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(40, 124);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name";
            // 
            // twitch_APILabel
            // 
            this.twitch_APILabel.AutoSize = true;
            this.twitch_APILabel.Location = new System.Drawing.Point(34, 171);
            this.twitch_APILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.twitch_APILabel.Name = "twitch_APILabel";
            this.twitch_APILabel.Size = new System.Drawing.Size(66, 13);
            this.twitch_APILabel.TabIndex = 3;
            this.twitch_APILabel.Text = "OUATH Key";
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(119, 193);
            this.HintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(151, 13);
            this.HintLabel.TabIndex = 4;
            this.HintLabel.Text = "Your key can be generated at:";
            // 
            // OkayBTN
            // 
            this.OkayBTN.Location = new System.Drawing.Point(255, 344);
            this.OkayBTN.Margin = new System.Windows.Forms.Padding(2);
            this.OkayBTN.Name = "OkayBTN";
            this.OkayBTN.Size = new System.Drawing.Size(81, 22);
            this.OkayBTN.TabIndex = 5;
            this.OkayBTN.Text = "Okay";
            this.OkayBTN.UseVisualStyleBackColor = true;
            this.OkayBTN.Click += new System.EventHandler(this.OkayBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(158, 344);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(81, 22);
            this.CancelBTN.TabIndex = 6;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // APILinkLabel
            // 
            this.APILinkLabel.AutoSize = true;
            this.APILinkLabel.Location = new System.Drawing.Point(275, 193);
            this.APILinkLabel.Name = "APILinkLabel";
            this.APILinkLabel.Size = new System.Drawing.Size(135, 13);
            this.APILinkLabel.TabIndex = 7;
            this.APILinkLabel.TabStop = true;
            this.APILinkLabel.Text = "http://twitchapps.com/tmi/";
            this.APILinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.APILinkLabel_LinkClicked);
            // 
            // ValidateBTN
            // 
            this.ValidateBTN.Location = new System.Drawing.Point(43, 227);
            this.ValidateBTN.Name = "ValidateBTN";
            this.ValidateBTN.Size = new System.Drawing.Size(88, 22);
            this.ValidateBTN.TabIndex = 8;
            this.ValidateBTN.Text = "Check";
            this.ValidateBTN.UseVisualStyleBackColor = true;
            this.ValidateBTN.Click += new System.EventHandler(this.ValidateBTN_Click);
            // 
            // ValidateText
            // 
            this.ValidateText.AutoSize = true;
            this.ValidateText.Location = new System.Drawing.Point(137, 232);
            this.ValidateText.Name = "ValidateText";
            this.ValidateText.Size = new System.Drawing.Size(25, 13);
            this.ValidateText.TabIndex = 9;
            this.ValidateText.Text = "......";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 376);
            this.Controls.Add(this.ValidateText);
            this.Controls.Add(this.ValidateBTN);
            this.Controls.Add(this.APILinkLabel);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.OkayBTN);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.twitch_APILabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.twitch_ApiTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox twitch_ApiTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label twitch_APILabel;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button OkayBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.LinkLabel APILinkLabel;
        private System.Windows.Forms.Button ValidateBTN;
        private System.Windows.Forms.Label ValidateText;
    }
}