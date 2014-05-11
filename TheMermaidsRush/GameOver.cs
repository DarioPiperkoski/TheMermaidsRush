using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheMermaidsRush
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            this.Height = 360;
            this.Width = 480;
            Point p = new Point(60, 230);
            btnYes.Location = p;
            btnYes.Height = 40;
            btnYes.Width = 150;
            p = new Point(260, 230);
            btnNo.Location = p;
            btnNo.Height = 40;
            btnNo.Width = 150;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            var mainMenu = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainMenu);
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
            this.Close();
        }
    }
}
