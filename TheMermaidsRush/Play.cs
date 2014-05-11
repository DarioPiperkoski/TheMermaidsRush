using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TheMermaidsRush.Properties;

namespace TheMermaidsRush
{
    public partial class Play : Form
    {

        System.Media.SoundPlayer MineSound = new System.Media.SoundPlayer(TheMermaidsRush.Properties.Resources.MineExplosion);
        System.Media.SoundPlayer NoteSound = new System.Media.SoundPlayer(TheMermaidsRush.Properties.Resources.NoteCollected);
        Point m, s;
        HighScoresEntry hse = new HighScoresEntry();
        List<Mine> Mini = new List<Mine>();
        List<Note> Noti = new List<Note>();
        private Random random;
        private int flag = 0;
        private int flag2 = 0;
        private int vkupnoNoti = 0;
        private int counter = 0;
        private int zivoti = 3;
        private int sharkDistance = -100;
        private int vreme = 100;
        private int interval = 0;

        public Play()
        {
            InitializeComponent();
            this.Height = 720;
            this.Width = 1280;
            DoubleBuffered = true;
            timer1 = new Timer();
            timer1.Interval = 33;
            random = new Random();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            pbMermaid.Location = new Point(390, 310);
            pbShark.Location = new Point(-100, pbMermaid.Location.Y - 35);
            
        }

        public void Dvizenje()
        {
            if (flag == 1)
            {
                m = pbMermaid.Location;

                if (m.Y > 45)
                {
                    m.Y -= 8;
                    pbMermaid.Location = m;
                    s = pbShark.Location;
                    s.Y = pbMermaid.Location.Y - 35;
                    pbShark.Location = s;
                }
            }

            else if (flag == 0)
            {
                m = pbMermaid.Location;

                if (m.Y + 15 < 550)
                {
                    m.Y += 15;
                    pbMermaid.Location = m;
                    s = pbShark.Location;

                    if (m.Y < 570)
                    {
                        s.Y = pbMermaid.Location.Y - 35;
                        pbShark.Location = s;
                    }
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Dvizenje();
            counter++;
            proveriPozicija();
            hse.lblScore.Text = vkupnoNoti.ToString();
            lblLives1.Text = zivoti.ToString();

            if ((sharkDistance == 300 || vreme == 0) && (vkupnoNoti > (int)Settings.Default["HighScore5"]))
            {
                timer1.Stop();

                var result = hse.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    brisiMiniNoti();
                    pbMermaid.Location = new Point(390, 310);
                    pbShark.Location = new Point(-100, pbMermaid.Location.Y - 60);
                    sharkDistance = -100;
                    flag = 0;
                    timer1.Start();
                    zivoti = 3;
                    vreme = 100;
                    interval = 0;
                    pbTime.Value = vreme;
                    vkupnoNoti = 0;
                    lblNotes.Text = "0";
                    lblLives1.Text = "3";
                }
                else if (result == DialogResult.No)
                {
                    vreme = -1;
                    this.Close();
                    proveriHighScore();
                    HighScores hs = new HighScores();
                    hs.Focus();
                    flag2 = 1;
                    hs.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }

            if ((sharkDistance == 300 || vreme == 0) && (vkupnoNoti <= (int)Settings.Default["HighScore5"]))
            {
                timer1.Stop();

                GameOver g = new GameOver();
                var result = g.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    brisiMiniNoti();
                    pbMermaid.Location = new Point(390, 310);
                    pbShark.Location = new Point(-100, pbMermaid.Location.Y - 60);
                    sharkDistance = -100;
                    flag = 0;
                    timer1.Start();
                    zivoti = 3;
                    vreme = 100;
                    interval = 0;
                    pbTime.Value = vreme;
                    vkupnoNoti = 0;
                    lblNotes.Text = "0";
                }
                else
                {
                    this.Close();
                }
            }


            if (counter % 1 == 0)
            {
                interval++;

                    if(interval %3 == 0)
                    {
                        vreme--;
                        if (vreme >= 0)
                        {
                            pbTime.Value = vreme;
                        }
                    }

                for (int i = 0; i < Mini.Count; i++)
                {
                    Mini[i].Move();

                    if (((Mini[i].posX <= 550) && (Mini[i].posX >= 390) && (Mini[i].posY >= pbMermaid.Location.Y + 20) && (Mini[i].posY <= pbMermaid.Location.Y + 80))
                        || ((Mini[i].posX <= 550) && (Mini[i].posX >= 390) && (Mini[i].posY + 75 >= pbMermaid.Location.Y + 20) && (Mini[i].posY + 75 <= pbMermaid.Location.Y + 80))
                        || ((Mini[i].posX + 75 <= 550) && (Mini[i].posX + 75 >= 390) && (Mini[i].posY >= pbMermaid.Location.Y + 20) && (Mini[i].posY <= pbMermaid.Location.Y + 80))
                        || ((Mini[i].posX + 75 <= 550) && (Mini[i].posX + 75 >= 390) && (Mini[i].posY + 75 >= pbMermaid.Location.Y + 20) && (Mini[i].posY + 75 <= pbMermaid.Location.Y + 80)))
                    {
                        sharkDistance += 100;
                        MineSound.Play();
                        Mini.RemoveAt(i);

                        if (zivoti > 0)
                        {
                            zivoti--;
                        }
                        
                        pbShark.Location = new Point(sharkDistance, pbMermaid.Location.Y - 50);
                    }
                    else if (Mini[i].posX < 0)
                    {
                        Mini.RemoveAt(i);
                    }
                }
            }

                    for (int i = 0; i < Noti.Count; i++)
                    {
                        Noti[i].Move();
                        if (((Noti[i].posX <= 550) && (Noti[i].posX >= 390) && (Noti[i].posY >= pbMermaid.Location.Y) && (Noti[i].posY <= pbMermaid.Location.Y + 100))
                            || ((Noti[i].posX <= 550) && (Noti[i].posX >= 390) && (Noti[i].posY + 83 >= pbMermaid.Location.Y) && (Noti[i].posY + 83 <= pbMermaid.Location.Y + 100))
                            || ((Noti[i].posX + 75 <= 550) && (Noti[i].posX + 75 >= 390) && (Noti[i].posY >= pbMermaid.Location.Y) && (Noti[i].posY <= pbMermaid.Location.Y + 100))
                            || ((Noti[i].posX + 75 <= 550) && (Noti[i].posX + 75 >= 390) && (Noti[i].posY + 83 >= pbMermaid.Location.Y) && (Noti[i].posY + 83 <= pbMermaid.Location.Y + 100)))
                        {
                            vkupnoNoti++;
                            NoteSound.Play();

                            if (vreme < 100 && vreme >= 88)
                            {
                                vreme = 100; ;
                            }

                            else if (vreme < 88 && vreme >= 0)
                            {
                                vreme += 12;
                                interval = 0;
                                pbTime.Value = vreme;
                            }

                            Noti.RemoveAt(i);

                            lblNotes.Text = string.Format("{0}", vkupnoNoti);
                        }

                        if (Noti[i].posX < 0)
                        {
                            Noti.RemoveAt(i);
                        }
                    }

                    if (counter % 15 == 0)
                    {
                        int y = random.Next(40, 550); ;
                        int x = 1200;
                        Mine mina = new Mine(x, y);
                        Mini.Add(mina);
                    }

                    if (counter % 30 == 8 && counter != 8)
                    {
                        int y1 = random.Next(40, 550); ;
                        int x1 = 1200;
                        Note nota = new Note(x1, y1);
                        Noti.Add(nota);
                    }
            Invalidate(true);
        }

        private void Play_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < Mini.Count; i++)
            {
                g.DrawImageUnscaled(Mini[i].img, Mini[i].posX, Mini[i].posY);
            }
            for (int i = 0; i < Noti.Count; i++)
            {
                g.DrawImageUnscaled(Noti[i].img, Noti[i].posX, Noti[i].posY);
            }
        }

        private void brisiMiniNoti()
        {
            for (int i = Mini.Count - 1; i >= 0; i--)
            {
                Mini.RemoveAt(i);
            }
            for (int i = Noti.Count - 1; i >= 0; i--)
            {
                Noti.RemoveAt(i);
            }
        }

        private void Play_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            { 
                flag = 0; 
            }
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up)) 
            { 
                flag = 1; 
            }

            if (e.KeyCode.Equals(Keys.P))
            {
                timer1.Stop();
                Pause P = new Pause();
                P.ShowDialog();
                flag = 0;
                timer1.Start();
            }
        }

        private void proveriHighScore()
        {
            if ((int)Settings.Default["HighScore1"] < vkupnoNoti)
            {
                Settings.Default["HighScore5"] = Settings.Default["HighScore4"];
                Settings.Default["HighScore4"] = Settings.Default["HighScore3"];
                Settings.Default["HighScore3"] = Settings.Default["HighScore2"];
                Settings.Default["HighScore2"] = Settings.Default["HighScore1"];
                Settings.Default["Name5"] = Settings.Default["Name4"];
                Settings.Default["Name4"] = Settings.Default["Name3"];
                Settings.Default["Name3"] = Settings.Default["Name2"];
                Settings.Default["Name2"] = Settings.Default["Name1"];
                Settings.Default["Name1"] = Settings.Default["Name"];
                Settings.Default["HighScore1"] = vkupnoNoti;

            }
            else if ((int)Settings.Default["HighScore2"] < vkupnoNoti)
            {
                Settings.Default["HighScore5"] = Settings.Default["HighScore4"];
                Settings.Default["HighScore4"] = Settings.Default["HighScore3"];
                Settings.Default["HighScore3"] = Settings.Default["HighScore2"];
                Settings.Default["Name5"] = Settings.Default["Name4"];
                Settings.Default["Name4"] = Settings.Default["Name3"];
                Settings.Default["Name3"] = Settings.Default["Name2"];
                Settings.Default["Name2"] = Settings.Default["Name"];
                Settings.Default["HighScore2"] = vkupnoNoti;
            }
            else if ((int)Settings.Default["HighScore3"] < vkupnoNoti)
            {
                Settings.Default["HighScore5"] = Settings.Default["HighScore4"];
                Settings.Default["HighScore4"] = Settings.Default["HighScore3"];
                Settings.Default["Name5"] = Settings.Default["Name4"];
                Settings.Default["Name4"] = Settings.Default["Name3"];
                Settings.Default["Name3"] = Settings.Default["Name"]; ;
                Settings.Default["HighScore3"] = vkupnoNoti;
            }
            else if ((int)Settings.Default["HighScore4"] < vkupnoNoti)
            {
                Settings.Default["HighScore5"] = Settings.Default["HighScore4"];
                Settings.Default["Name5"] = Settings.Default["Name4"];
                Settings.Default["Name4"] = Settings.Default["Name"]; ;
                Settings.Default["HighScore4"] = vkupnoNoti;
            }
            else if ((int)Settings.Default["HighScore5"] < vkupnoNoti)
            {
                Settings.Default["Name5"] = Settings.Default["Name"]; ;
                Settings.Default["HighScore5"] = vkupnoNoti;
            }
            timer1.Stop();
            TextWriter tw = new StreamWriter("Names.txt");

            tw.WriteLine(Settings.Default["Name1"]);
            tw.WriteLine(Settings.Default["Name2"]);
            tw.WriteLine(Settings.Default["Name3"]);
            tw.WriteLine(Settings.Default["Name4"]);
            tw.WriteLine(Settings.Default["Name5"]);
            tw.Close();

            tw = new StreamWriter("Scores.txt");
            tw.WriteLine(Settings.Default["HighScore1"]);
            tw.WriteLine(Settings.Default["HighScore2"]);
            tw.WriteLine(Settings.Default["HighScore3"]);
            tw.WriteLine(Settings.Default["HighScore4"]);
            tw.WriteLine(Settings.Default["HighScore5"]);
            tw.Close();
        }

        public void proveriPozicija()
        {
            if (vkupnoNoti > (int)Settings.Default["HighScore1"])
            {
                hse.lblPosition.Text = "#1";
            }
            else if (vkupnoNoti > (int)Settings.Default["HighScore2"])
            {
                hse.lblPosition.Text = "#2";
            }
            else if (vkupnoNoti > (int)Settings.Default["HighScore3"])
            {
                hse.lblPosition.Text = "#3";
            }
            else if (vkupnoNoti > (int)Settings.Default["HighScore4"])
            {
                hse.lblPosition.Text = "#4";
            }
            else if (vkupnoNoti > (int)Settings.Default["HighScore5"])
            {
                hse.lblPosition.Text = "#5";
            }
        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag2 == 1)
            {
                timer1.Stop();
            }
            if (flag2 == 0)
            {
                proveriHighScore();
                timer1.Stop();
            }
        }



    }
}
