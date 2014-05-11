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
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
            this.Height = 360;
            this.Width = 480;
        }

        private void Pause_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.R))
                this.Close();
        }
    }
}
