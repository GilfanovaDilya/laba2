using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryForLab2_v1
{
    public class Ellips1 : Figure
    {
        public Ellips1(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public Ellips1()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }

        public void radius(Figure figure, int w, int h, int r)
        {
            this.h += r;
            this.w += r;
            DeleteF(figure, false);
            this.Draw();
        }

        public override void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
            this.DeleteF(this, false);
            this.Draw();
        }
    }
}