namespace TwitchPlaysAnything
{
    partial class ControlSchemeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlDataGridView = new System.Windows.Forms.DataGridView();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkOrchid;
            this.controlDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.controlDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.controlDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.controlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlDataGridView.EnableHeadersVisualStyles = false;
            this.controlDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlDataGridView.Location = new System.Drawing.Point(9, 64);
            this.controlDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.controlDataGridView.Name = "controlDataGridView";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.controlDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.controlDataGridView.RowTemplate.Height = 24;
            this.controlDataGridView.Size = new System.Drawing.Size(621, 333);
            this.controlDataGridView.TabIndex = 0;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(11, 40);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(139, 20);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Location = new System.Drawing.Point(12, 25);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(35, 13);
            this.NameBox.TabIndex = 2;
            this.NameBox.Text = "Name";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(245, 412);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okayBtn
            // 
            this.okayBtn.Location = new System.Drawing.Point(326, 412);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(75, 23);
            this.okayBtn.TabIndex = 4;
            this.okayBtn.Text = "Okay";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // ControlSchemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 447);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.controlDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ControlSchemeForm";
            this.Text = "ControlSchemeForm";
            this.Load += new System.EventHandler(this.ControlSchemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView controlDataGridView;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okayBtn;
    }
}