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
        int scale = 1; //масштаб в pictureBox1
        double Alpha; // Величина сектора в градусах

        public Form1()
        {
            InitializeComponent();
            this.trackBarAngle.Scroll += new EventHandler(trackBarAngle_Scroll);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarAngle.Minimum = 0;
            trackBarAngle.Maximum = 90;
            trackBarAngle.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            pictureBox1.Refresh();
            if (tbR.Text == String.Empty) { MessageBox.Show("Заполните поле:'Радиус окружности'"); return; }
            if (tbCx.Text == String.Empty) { MessageBox.Show("Заполните поле:'Координаты центра окружности X'"); return; }
            if (tbCy.Text == String.Empty) { MessageBox.Show("Заполните поле:'Координаты центра окружности Y'"); return; }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (tbR.Text != String.Empty && tbCx.Text != String.Empty && tbCy.Text != String.Empty) 
            {
                //Переменные для вычислений.
                double Radius = double.Parse(tbR.Text);
                double Xcenter = double.Parse(tbCx.Text);
                double Ycenter = double.Parse(tbCy.Text);
                double Xpoint, Ypoint;
                string Xintersection, Yintersection;

                //Переменные для рисования.
                float RadiusF = (float)(float.Parse(tbR.Text) * float.Parse(Convert.ToString(scale)));
                float DiameterF = (float)( 2F * float.Parse(tbR.Text) * float.Parse(Convert.ToString(scale)));
                float XcenterF = (float)(float.Parse(tbCx.Text) * float.Parse(Convert.ToString(scale)));
                float YcenterF = (float)(float.Parse(tbCy.Text) * float.Parse(Convert.ToString(scale)));
                float HalfRadius = (float)(RadiusF / 2 * float.Parse(Convert.ToString(scale)));
                var G = e.Graphics;
                G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                G.TranslateTransform((float)(pictureBox1.Width / 2), (float)(pictureBox1.Height / 2)); //Перенос начала координат в центр элемента формы pictureBox1.
                Pen Pen = new Pen(Color.Black, 2);
                Pen PenAxis = new Pen(Color.Blue, 1);
                Pen PenLine = new Pen(Color.Red, 1);
                SolidBrush BrushEllipse = new SolidBrush(Color.Red);

                //На pictureBox1 строются окружность, оси координат и точка с координатами (0,0).
                G.DrawLine(PenAxis, (float)(-pictureBox1.Width), 0F, (float)(pictureBox1.Width), 0F); //Ось абсцисс.
                G.DrawLine(PenAxis, 0F, (float)(-pictureBox1.Height), 0F, (float)(pictureBox1.Height)); //Ось ординат.
                RectangleF Rect = new RectangleF((float)(XcenterF - RadiusF), (float)(-YcenterF - RadiusF), DiameterF, DiameterF);
                G.DrawEllipse(Pen, Rect); //Рисуем окружность.
                RectangleF Point = new RectangleF(-3F, -3F, 6F, 6F);
                G.FillEllipse(BrushEllipse, Point); //Рисуем точку в начале координат из которой пойдут отрезки.

                //На pictureBox1 строются точки пересечения окружности и отрезков из точки с координатами (0,0).
                if (Radius == 0) { MessageBox.Show("Радиус окружности не должен быть равен нулю."); return; }
                richTextBox1.AppendText("Радиус окружности: " + Convert.ToString(Radius) + ";\n" + "Координаты центра окружности: X = " + Convert.ToString(Xcenter) + ", Y = " + Convert.ToString(Ycenter) + ";\n\n");
                if (tbLx1.Text != String.Empty && tbLy1.Text != String.Empty)
                {
                    Xpoint = double.Parse(tbLx1.Text);
                    Ypoint = double.Parse(tbLy1.Text);
                    IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                    if (Xintersection != "NotExist" && Yintersection != "NotExist")
                    {
                        RectangleF Point1 = new RectangleF((float)(float.Parse(Xintersection) - 3F), (float)(-float.Parse(Yintersection) - 3F), 6F, 6F);
                        G.FillEllipse(BrushEllipse, Point1); //Ближайшая точка пересечения прямой с окружностью.
                        G.DrawLine(PenLine, 0F, 0F, float.Parse(Xintersection), -float.Parse(Yintersection)); //Отрезок из начала координат до точки пересечения с окружностью.
                    }
                }
                if (tbLx2.Text != String.Empty && tbLy2.Text != String.Empty)
                {
                    Xpoint = double.Parse(tbLx2.Text);
                    Ypoint = double.Parse(tbLy2.Text);
                    IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                    if (Xintersection != "NotExist" && Yintersection != "NotExist") 
                    {
                        RectangleF Point2 = new RectangleF((float)(float.Parse(Xintersection) - 3F), (float)(-float.Parse(Yintersection) - 3F), 6F, 6F);
                        G.FillEllipse(BrushEllipse, Point2); //Ближайшая точка пересечения прямой с окружностью.
                        G.DrawLine(PenLine, 0F, 0F, float.Parse(Xintersection), -float.Parse(Yintersection)); //Отрезок из начала координат до точки пересечения с окружностью.
                    }
                }
                if (tbLx3.Text != String.Empty && tbLy3.Text != String.Empty)
                {
                    Xpoint = double.Parse(tbLx3.Text);
                    Ypoint = double.Parse(tbLy3.Text);
                    IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                    if (Xintersection != "NotExist" && Yintersection != "NotExist") 
                    {
                        RectangleF Point3 = new RectangleF((float)(float.Parse(Xintersection) - 3F), (float)(-float.Parse(Yintersection) - 3F), 6F, 6F);
                        G.FillEllipse(BrushEllipse, Point3); //Ближайшая точка пересечения прямой с окружностью.
                        G.DrawLine(PenLine, 0F, 0F, float.Parse(Xintersection), -float.Parse(Yintersection)); //Отрезок из начала координат до точки пересечения с окружностью.
                    }
                }
                if (tbLx4.Text != String.Empty && tbLy4.Text != String.Empty)
                {
                    Xpoint = double.Parse(tbLx4.Text);
                    Ypoint = double.Parse(tbLy4.Text);
                    IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                    if (Xintersection != "NotExist" && Yintersection != "NotExist")
                    {
                        RectangleF Point4 = new RectangleF((float)(float.Parse(Xintersection) - 3F), (float)(-float.Parse(Yintersection) - 3F), 6F, 6F);
                        G.FillEllipse(BrushEllipse, Point4); //Ближайшая точка пересечения прямой с окружностью.
                        G.DrawLine(PenLine, 0F, 0F, float.Parse(Xintersection), -float.Parse(Yintersection)); //Отрезок из начала координат до точки пересечения с окружностью.
                    }
                }
                if (tbLx5.Text != String.Empty && tbLy5.Text != String.Empty)
                {
                    Xpoint = double.Parse(tbLx5.Text);
                    Ypoint = double.Parse(tbLy5.Text);
                    IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                    if (Xintersection != "NotExist" && Yintersection != "NotExist") 
                    {
                        RectangleF Point5 = new RectangleF((float)(float.Parse(Xintersection) - 3F), (float)(-float.Parse(Yintersection) - 3F), 6F, 6F);
                        G.FillEllipse(BrushEllipse, Point5); //Ближайшая точка пересечения прямой с окружностью.
                        G.DrawLine(PenLine, 0F, 0F, float.Parse(Xintersection), -float.Parse(Yintersection)); //Отрезок из начала координат до точки пересечения с окружностью.
                    }
                }
                if (tbLx6.Text != String.Empty && tbLy6.Text != String.Empty && Alpha != 0)
                {
                    RectangleF PointT;
                    double Xvector = double.Parse(tbLx6.Text);
                    double Yvector = double.Parse(tbLy6.Text);
                    double Dx = -Xvector; //Координата X вектора начало и конец которого заданы точками AO.
                    double Dy = -Yvector; //Координата Y вектора начало и конец которого заданы точками AO.
                    double k1 = Dx * Dx + Dy * Dy; // Квадрат радиуса в полярных координатах для заданной точки
                    double Phi = Math.Acos(Xvector / Math.Sqrt(k1)) * 180.0 / Math.PI; // Угол (в градусах) через который выражаются координаты заданной точки в полярных координатах
                    if (Yvector < 0) Phi = 360.0 - Phi;
                    double T = Alpha / 10; // Интервал отрезков в секторе
                    for (double i = Alpha / 2; i >= -Alpha / 2; i -= T)
                    {
                        Xpoint = Math.Cos((Phi + i) * Math.PI / 180.0);
                        Ypoint = Math.Sin((Phi + i) * Math.PI / 180.0);
                        IntersectRayCircle(0.0, 0.0, Xpoint, Ypoint, Xcenter, Ycenter, Radius, out Xintersection, out Yintersection);
                        if (Xintersection != "NotExist" && Yintersection != "NotExist")
                        {
                            PointT = new RectangleF((float)(float.Parse(Xintersection) - 3F), (float)(-float.Parse(Yintersection) - 3F), 6F, 6F);
                            G.FillEllipse(BrushEllipse, PointT); //Ближайшая точка пересечения прямой с окружностью.
                            G.DrawLine(PenLine, 0F, 0F, float.Parse(Xintersection), -float.Parse(Yintersection)); //Отрезок из начала координат до точки пересечения с окружностью.
                        }
                    }
                }


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
            //MessageBox.Show(xOut, yOut);
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

        private void tbLx6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void tbLy6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //Цифры, клавиша BackSpace, запятая и минус.
            {
                e.Handled = true;
            }
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBarAngle, trackBarAngle.Value.ToString());
            Alpha = trackBarAngle.Value;
        }

    }
}
