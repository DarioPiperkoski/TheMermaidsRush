using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheMermaidsRush.Properties;

namespace TheMermaidsRush
{
    public partial class HighScoresEntry : Form
    {
        public HighScoresEntry()
        {
            InitializeComponent();
            this.Height = 480;
            this.Width = 640;
            Point p = new Point(80, 360);
            btnPlay.Location = p;
            btnPlay.Height = 40;
            btnPlay.Width = 200;
            p = new Point(350, 360);
            btnSubmit.Location = p;
            btnSubmit.Height = 40;
            btnSubmit.Width = 200;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void addName()
        {
            if (tbName.Text.Trim() == "")
            {
                Settings.Default["Name"] = "Unnamed";
            }
            else
            {
                Settings.Default["Name"] = tbName.Text;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void HighScoresEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            addName();
        }
    }
}
