using System.Drawing;
using System.Windows.Forms;
using ClassLibraryForLab2_v1;

namespace WindowsForms_Dilya_lab_2_v1
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 3);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = this.pen;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Point point1 = new Point(50, 300);
            Point point2 = new Point(150, 300);
            Point point3 = new Point(150, 400);
            Point[] curvePoints = { point1, point2, point3 };
            Tri1 tri1 = new Tri1(curvePoints);
            tri1.Draw();
            ShapeContainer.AddFigure(tri1);

            Rectangle1 rectangle = new Rectangle1(150, 300, 200, 100);
            rectangle.Draw();
            ShapeContainer.AddFigure(rectangle);

            point1 = new Point(350, 300);
            point2 = new Point(350, 400);
            point3 = new Point(450, 300);
            curvePoints[0] = point1;
            curvePoints[1] = point2;
            curvePoints[2] = point3;
            Tri1 tri2 = new Tri1(curvePoints);
            tri2.Draw();
            ShapeContainer.AddFigure(tri2);

            point1 = new Point(380, 300);
            point2 = new Point(250, 300);
            point3 = new Point(250, 100);
            curvePoints[0] = point1;
            curvePoints[1] = point2;
            curvePoints[2] = point3;
            Tri1 tri3 = new Tri1(curvePoints);
            tri3.Draw();
            ShapeContainer.AddFigure(tri3);

            point1 = new Point(250, 150);
            point2 = new Point(150, 150);
            point3 = new Point(250, 100);
            curvePoints[0] = point1;
            curvePoints[1] = point2;
            curvePoints[2] = point3;
            Tri1 tri4 = new Tri1(curvePoints);
            tri4.Draw();
            ShapeContainer.AddFigure(tri4);

            Okr1 okr1 = new Okr1(170, 310, 40);
            okr1.Draw();
            ShapeContainer.AddFigure(okr1);
            Okr1 okr2 = new Okr1(230, 310, 40);
            okr2.Draw();
            ShapeContainer.AddFigure(okr2);
            Okr1 okr3 = new Okr1(280, 310, 40);
            okr3.Draw();
            ShapeContainer.AddFigure(okr3);
        }
    }
}
