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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
            this.Width = 480;
            this.Height = 360;
            Point p = new Point(50, 200);
            btnYes.Location = p;
            btnYes.Height = 40;
            btnYes.Width = 150;
            p = new Point(280, 200);
            btnNo.Location = p;
            btnNo.Height = 40;
            btnNo.Width = 150;
            //.......
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
