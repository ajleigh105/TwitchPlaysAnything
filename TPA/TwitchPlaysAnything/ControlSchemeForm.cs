using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwitchPlaysAnything
{
    public partial class ControlSchemeForm : Form
    {
        DataTable dtTable = new DataTable("commands");
        string oldPath = "", newPath = "";

        public ControlSchemeForm()
        {
            InitializeComponent();
            ControlsRefresh();
        }

        public ControlSchemeForm(string path)
        {
            InitializeComponent();
            oldPath = path;
            newPath = path;
            pathTextBox.Text = path;
            ControlsRefresh();
        }

        private void ControlSchemeForm_Load(object sender, EventArgs e)
        {
        }

        private void ControlsRefresh()
        {
            List<string> lines = new List<string>();

            using (StreamReader r = new StreamReader("control_map.stgs"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            dtTable.Columns.Add("Command");
            dtTable.Columns.Add("Key");
            dtTable.Columns.Add("Time");

            if (File.Exists("Controls/" + oldPath + ".ctr")){
                foreach (string control_line in System.IO.File.ReadLines("Controls/" + pathTextBox.Text + ".ctr"))
                {
                    string[] ControlSplit = control_line.Split(':');
                    string[] row = new string[] { ControlSplit[0], ControlSplit[1], ControlSplit[2] };
                    dtTable.Rows.Add(row);
                    //controlDataGridView.Rows.Add(row);
                }
            }
            // ADD DATATABLE TO GRID. (WITH THE BLANK ROWS)
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.DataPropertyName = "Key";
            col.HeaderText = "Key";
            col.Name = "Key";
            col.Items.Add("True");
            col.DataSource = lines;
            controlDataGridView.Columns.Add(col);
            controlDataGridView.DataSource = dtTable;

            controlDataGridView.Columns["Command"].DisplayIndex = 0;
            controlDataGridView.Columns["Key"].DisplayIndex = 1;
            controlDataGridView.Columns["Time"].DisplayIndex = 2;
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            newPath = pathTextBox.Text;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            List<string> controlList = new List<string>();

            foreach (DataGridViewRow row in controlDataGridView.Rows)
            {
                string parsedRow = "";
                foreach(DataGridViewCell cell in row.Cells)
                {
                    parsedRow = parsedRow + cell.Value + ":";
                }
                if (parsedRow.Replace(':', ' ').Trim().Length > 0)
                {
                    parsedRow = parsedRow.Substring(0, parsedRow.Length - 1);
                    controlList.Add(parsedRow);
                }
            }
            System.IO.File.WriteAllLines("Controls/" + newPath + ".ctr", controlList);

            if(newPath != oldPath)
            {
                try
                {
                    File.Delete("Controls/" + oldPath + ".ctr");
                }
                catch
                {

                }
            }
            this.Close();
        }
    }
}
