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
    /// <summary>
    /// abstract class Figures
    /// </summary>
    public abstract class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public Point[] curvePoints;
        public abstract void Draw();
        public abstract void MoveTo(int x, int y);

        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
                ShapeContainer.figureList.Add(figure);
            }
        }

        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }

    public static class Init
    {
        public static Bitmap bitmap { get; set; }
        public static PictureBox pictureBox { get; set; }
        public static Pen pen { get; set; }
    }

}
