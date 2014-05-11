using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TheMermaidsRush
{
    public class Note
    {
        public int posX, posY;
        public Image img { get; set; }

        public Note(int x, int y)
        {
            posX = x;
            posY = y;
            img = TheMermaidsRush.Properties.Resources.Note;
        }

        public void Move()
        {
            posX -= 20;
        }
    }
}
