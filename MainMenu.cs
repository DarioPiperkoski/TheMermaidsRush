using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheMermaidsRush.Properties;
using System.IO;

namespace TheMermaidsRush
{
    public partial class MainMenu : Form
    {
        System.Media.SoundPlayer BackgroundMusic = new System.Media.SoundPlayer(TheMermaidsRush.Properties.Resources.BackgroundMusic);
        private int counter = 0;

        public MainMenu()
        {
            InitializeComponent();
            this.Height = 480;
            this.Width = 640;
            Point p = new Point(50, 260);
            btnPlay.Location = p;
            btnPlay.Height = 40;
            btnPlay.Width = 180;
            p = new Point(50, 315);
            btnHS.Location = p;
            btnHS.Height = 40;
            btnHS.Width = 180;
            p = new Point(50, 370);
            btnHTP.Location = p;
            btnHTP.Height = 40;
            btnHTP.Width = 180;
            p = new Point(410, 370);
            btnExit.Location = p;
            btnExit.Height = 40;
            btnExit.Width = 180;
            p = new Point(560, 10);
            btnSound.Location = p;
            btnSound.Height = 50;
            btnSound.Width = 50;
            BackgroundMusic.PlayLooping();
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.Height = 45;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Width = 180;
            btnPlay.Height = 40;
        }

        private void btnHS_MouseEnter(object sender, EventArgs e)
        {
            btnHS.Height = 45;
        }

        private void btnHS_MouseLeave(object sender, EventArgs e)
        {
            btnHS.Width = 180;
            btnHS.Height = 40;
        }

        private void btnHTP_MouseEnter(object sender, EventArgs e)
        {
            btnHTP.Height = 45;
        }

        private void btnHTP_MouseLeave(object sender, EventArgs e)
        {
            btnHTP.Width = 180;
            btnHTP.Height = 40;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Height = 45;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Width = 180;
            btnExit.Height = 40;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Stop();
            Play p = new Play();
            this.Hide();
            p.ShowDialog();
            if (counter == 0)
            {
                BackgroundMusic.PlayLooping();
            }
            this.Show();
        }

        private void btnHS_Click(object sender, EventArgs e)
        {
            HighScores hs = new HighScores();
            this.Hide();
            hs.ShowDialog();
            this.Show();
        }

        private void btnHTP_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            this.Hide();
            htp.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Exit ex = new Exit();
            dr = ex.ShowDialog();
            {
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void zapisiHighScores()
        {
            TextReader tr = new StreamReader("Names.txt");

            Settings.Default["Name1"] = tr.ReadLine();
            Settings.Default["Name2"] = tr.ReadLine();
            Settings.Default["Name3"] = tr.ReadLine();
            Settings.Default["Name4"] = tr.ReadLine();
            Settings.Default["Name5"] = tr.ReadLine();
            tr.Close();

            tr = new StreamReader("Scores.txt");
            if (tr.ReadLine() != null)
            {
                Settings.Default["HighScore1"] = int.Parse(tr.ReadLine());
            }
            else
            {
                Settings.Default["HighScore1"] = 0;
                tr.ReadLine();
            }
            
            if (tr.ReadLine() != null)
            {
                Settings.Default["HighScore2"] = int.Parse(tr.ReadLine());
            }
            else
            {
                Settings.Default["HighScore2"] = 0;
                tr.ReadLine();
            }
            
            if (tr.ReadLine() != null)
            {
                Settings.Default["HighScore3"] = int.Parse(tr.ReadLine());
            }
            else
            {
                Settings.Default["HighScore3"] = 0;
                tr.ReadLine();
            }
            
            if (tr.ReadLine() != null)
            {
                Settings.Default["HighScore4"] = int.Parse(tr.ReadLine());
            }
            else
            {
                Settings.Default["HighScore4"] = 0;
                tr.ReadLine();
            }
            
            if (tr.ReadLine() != null)
            {
                Settings.Default["HighScore5"] = int.Parse(tr.ReadLine());
            }
            else
            {
                Settings.Default["HighScore5"] = 0;
                tr.ReadLine();
            }
            tr.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            zapisiHighScores();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                btnSound.BackgroundImage = TheMermaidsRush.Properties.Resources.SoundOn;
                BackgroundMusic.PlayLooping();
                counter = 0;
            }
            else
            {
                btnSound.BackgroundImage = TheMermaidsRush.Properties.Resources.SoundOff;
                BackgroundMusic.Stop();
                counter++;
            }
        }

    }
}
