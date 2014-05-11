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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
            this.Height = 480;
            this.Width = 640;

            if (Settings.Default["Name1"] != null)
            {
                lblName1.Text = Settings.Default["Name1"].ToString();
            }
            if (Settings.Default["Name2"] != null)
            {
                lblName2.Text = Settings.Default["Name2"].ToString();
            }
            if (Settings.Default["Name3"] != null)
            {
                lblName3.Text = Settings.Default["Name3"].ToString();
            }
            if (Settings.Default["Name4"] != null)
            {
                lblName4.Text = Settings.Default["Name4"].ToString();
            }
            if(Settings.Default["Name5"] != null)
            {
                lblName5.Text = Settings.Default["Name5"].ToString();
            }
            if (Settings.Default["HighScore1"] != null)
            {
                lblScore1.Text = Settings.Default["HighScore1"].ToString();
            }
            if (Settings.Default["HighScore2"] != null)
            {
                lblScore2.Text = Settings.Default["HighScore2"].ToString();
            }
            if (Settings.Default["HighScore3"] != null)
            {
                lblScore3.Text = Settings.Default["HighScore3"].ToString();
            }
            if (Settings.Default["HighScore4"] != null)
            {
                lblScore4.Text = Settings.Default["HighScore4"].ToString();
            }
            if (Settings.Default["HighScore5"] != null)
            {
                lblScore5.Text = Settings.Default["HighScore5"].ToString();
            }

            }
        }
    }
