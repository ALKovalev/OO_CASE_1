using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CircleAndLineCSharp
{
    public partial class Form1 : Form
    {
        int Scale; //масштаб в pictureBox1

        public Form1()
        {
            InitializeComponent();
            this.trackBar1.Scroll += new EventHandler(trackBar1_Scroll);
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            pictureBox1.Refresh();
            if (tbR.Text == String.Empty) { MessageBox.Show("Заполните поле:'Радиус окружности'"); return; }
            if (tbCx.Text == String.Empty) { MessageBox.Show("Заполните поле:'Координаты центра окружности X'"); return; }
            if (tbCy.Text == String.Empty) { MessageBox.Show("Заполните поле:'Координаты центра окружности Y'"); return; }
            double Radius = double.Parse(tbR.Text);
            double Xcenter = double.Parse(tbCx.Text);
            double Ycenter = double.Parse(tbCy.Text);
            double Xpoint, Ypoint;
            string Xintersection, Yintersection;
            if (Radius == 0) { MessageBox.Show("Радиус окружности не должен быть равен нулю."); return; }
            richTextBox1.AppendText("Радиус окружности: " + Convert.ToString(Radius) + ";\n" + "Координаты центра окружности: X = " + Convert.ToString(Xcenter) + ", Y = " + Convert.ToString(Ycenter) + ";\n\n");
            if (tbLx1.Text == String.Empty || tbLy1.Text == String.Empty) { } 
            else 
            {
                Xpoint = double.Parse(tbLx1.Text);
                Ypoint = double.Parse(tbLy1.Text);
                IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                PaintIntersectionPoint(Xintersection, Yintersection);
            }
            if (tbLx2.Text == String.Empty || tbLy2.Text == String.Empty) { }
            else
            {
                Xpoint = double.Parse(tbLx2.Text);
                Ypoint = double.Parse(tbLy2.Text);
                IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                PaintIntersectionPoint(Xintersection, Yintersection);
            }
            if (tbLx3.Text == String.Empty || tbLy3.Text == String.Empty) { }
            else
            {
                Xpoint = double.Parse(tbLx3.Text);
                Ypoint = double.Parse(tbLy3.Text);
                IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                PaintIntersectionPoint(Xintersection, Yintersection);
            }
            if (tbLx4.Text == String.Empty || tbLy4.Text == String.Empty) { }
            else
            {
                Xpoint = double.Parse(tbLx4.Text);
                Ypoint = double.Parse(tbLy4.Text);
                IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                PaintIntersectionPoint(Xintersection, Yintersection);
            }
            if (tbLx5.Text == String.Empty || tbLy5.Text == String.Empty) { }
            else
            {
                Xpoint = double.Parse(tbLx5.Text);
                Ypoint = double.Parse(tbLy5.Text);
                IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                PaintIntersectionPoint(Xintersection, Yintersection);
            }


        }

        private void PaintIntersectionPoint(string Xintersection, string Yintersection)
        {
            //На pictureBox1 с каждым вызовом метода рисуется одна точка пересечения прямой методом с окружностью методом .DrawEllipse и прямая к ней методом .DrawLine из точки (0,0)
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (tbR.Text == String.Empty) { }
            else 
            {
                
                var G = e.Graphics;
                G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                Pen Pen = new Pen(Color.Black, 7);
                //RectangleF Rect = new RectangleF(0.0F, 0.0F, 0.0F, 0.0F);
                //G.DrawEllipse(Pen, Rect);
                //На pictureBox1 с каждым вызовом метода рисуется окружность методом .DrawEllipse, точка с координатами (0,0) методом .DrawEllipse
            }

        }


        private void IntersectRayCircle(double Ox, double Oy, double Ax, double Ay, double Cx, double Cy, double R, out string xOut, out string yOut)
        {
            double OCx = Ox - Cx; //Координата X вектора из начальной точки O в центр окружности C.
            double OCy = Oy - Cy; //Координата Y вектора из начальной точки O в центр окружности C.
            double Dx = Ox - Ax; //Координата X вектора начало и конец которого заданы точками AO.
            double Dy = Oy - Ay; //Координата Y вектора начало и конец которого заданы точками AO.
            double k1 = Dx * Dx + Dy * Dy; //k1, k2, k3 это слагаемые в квадратном уравнении,
            double k2 = 2 * (OCx * Dx + OCy * Dy); //полученном после решения системы уравнений,
            double k3 = (OCx * OCx + OCy * OCy) - R * R; //состоящей из параметрического уравнения прямой, проходящей через две заданные точки и уравнения окружности.
            double discriminant = k2 * k2 - 4 * k1 * k3; //Дискриминант квадратного уравнения.
            const double Eps = 1e-10; //Величина близкая у нулю для избежания проблем с точностью операций вычисления.
            xOut = "NotExist"; //Инициализация координаты X ближайшей точки пересечения.
            yOut = "NotExist"; //Инициализация координаты Y ближайшей точки пересечения.
            if (Math.Sqrt(k1) < Eps)
            {
                richTextBox1.AppendText("Длина заданного отрезка близка к нулю.\n\n");
            }
            else
            {
                if (discriminant < 0)
                {
                    richTextBox1.AppendText("Окружность и прямая не имеют общих точек.\n\n");
                }
                if (discriminant == 0)
                {
                    double t = -k2 / (2 * k1);
                    double xAns = Ox + t * Dx;
                    double yAns = Oy + t * Dy;
                    richTextBox1.AppendText("Окружность и прямая имеют одну общую точку. X = " + Convert.ToString(xAns) + ", Y = " + Convert.ToString(yAns) + ";\n\n");
                    xOut = Convert.ToString(xAns);
                    yOut = Convert.ToString(yAns);
                }
                if (discriminant > 0)
                {
                    double t1 = (-k2 + Math.Sqrt(discriminant)) / (2 * k1);
                    double t2 = (-k2 - Math.Sqrt(discriminant)) / (2 * k1);
                    double xAns1 = Ox + t1 * Dx;
                    double yAns1 = Oy + t1 * Dy;
                    double xAns2 = Ox + t2 * Dx;
                    double yAns2 = Oy + t2 * Dy;
                    if (Math.Abs(t1) < Math.Abs(t2))
                    {
                        richTextBox1.AppendText("Окружность и прямая имеют две общие точки. Координаты ближайшей: X = " + Convert.ToString(xAns1) + ", Y = " + Convert.ToString(yAns1) + ";\n\n");
                        xOut = Convert.ToString(xAns1);
                        yOut = Convert.ToString(yAns1);
                    }
                    else
                    {
                        richTextBox1.AppendText("Окружность и прямая имеют две общие точки. Координаты ближайшей: X = " + Convert.ToString(xAns2) + ", Y = " + Convert.ToString(yAns2) + ";\n\n");
                        xOut = Convert.ToString(xAns2);
                        yOut = Convert.ToString(yAns2);
                    }
                }
            }
            MessageBox.Show(xOut, yOut);
        }

        private void tbR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //Цифры, клавиша BackSpace и запятая.
            {
                e.Handled = true;
            }
        }

        private void tbCx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbCy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLy1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLy2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLy3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLy4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLx5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLy5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
            Scale = trackBar1.Value;
        }

        
    }
}
