using System.Drawing.Drawing2D;

namespace Project2_Graphics
{
    public enum Direzione
    {
        AVANTI,
        INDIETRO
    }

    public partial class Form1 : Form
    {
        double step = 0.1f;
        float xmin = -5.0f, xmax = 5.0f, ymin = -5.0f, ymax = 5.0f;
        int mouse_x, mouse_y;
        int w, h;

        Direzione dir;
        double x=0, y=0; //coordinate palla
        double m, q; //m e q della retta della palla y = mx+q
        Pen drawPen;

        public Form1()
        {
            InitializeComponent(); //do not delete this line!!! 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pianoCartesiano.Paint += pianoOnPaint;
            pianoCartesiano.Resize += pianoOnResize;
            pianoCartesiano.MouseMove += pianoOnMouseMove;

            drawPen = new Pen(ForeColor);
        }


        private void pianoOnPaint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            w = pianoCartesiano.Width;
            h = pianoCartesiano.Height;

            //update the size label
            dimPiano.Text = String.Format("{0}, {1}", w, h);

            g.Clear(pianoCartesiano.BackColor); // cancella tutto
            //drawLine(g, Pens.Black, xmin, 0, xmax, 0); // x axis (y=0)
            //drawLine(g, Pens.Black, 0, ymin, 0, ymax); // y axis (x=0)

            //linea di debug
            drawLine(g, drawPen, 0, 0, (float)x, (float)(m * x + q));
            moveBall((float)x, (float)(m * x + q));

        }


        private double randomAngle()
        {
            Random r = new Random();
            float n = r.NextSingle();
            if (n > 0.5f)
            {
                return r.NextDouble() * 90;
            }
            else
            {
                return -r.NextDouble() * 90;
            }
        }
        private Direzione randomDirection()
        {
            Random r = new Random();
            float n = r.NextSingle();
            if (n > 0.5f)
            {
                return Direzione.AVANTI;
            }
            else
            {
                return Direzione.INDIETRO;
            }
        }

        private double toRadiant(double a)
        {
            //a:180 = rad:pi --| rad =a*pi/180
            return a * Math.PI / 180.0f;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double deg = randomAngle();
            double rad = toRadiant(deg);
            m = Math.Atan(rad); //m della retta della palla;
            Console.WriteLine("gradi = {0:0.00}, radianti = {1:0.00}, pm = {2:0.00}", deg, rad, m);

            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dir == Direzione.AVANTI)
            {
                x += step;
                if (x>xmax)
                {
                    dir = Direzione.INDIETRO;
                }
            } else if (dir == Direzione.INDIETRO)
            {
                x -= step;
                if (x < xmin)
                {
                    dir = Direzione.AVANTI;
                }
            }

            pianoCartesiano.Invalidate();
        }

        private void drawAxes_CheckedChanged(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }

        private PointF pixelToPoint(int px, int py)
        {
            float fx = (float)px / (float)w; // fx in the interval [0 ; 1] from left to right
            float fy = 1.0f - (float)py / (float)h; // fy in the interval [0 ; 1] from bottom to top
            return new PointF(xmin + (xmax - xmin) * fx, ymin + (ymax - ymin) * fy);
        }

        private Point pointToPixel(float x, float y)
        {
            float fx = (x - xmin) / (xmax - xmin);
            float fy = (y - ymin) / (ymax - ymin);
            return new Point((int)(fx * (float)w), (int)((1.0f - fy)*(float)h));
        }

        private void drawLine(Graphics g, Pen pen, float x1, float y1, float x2, float y2)
        {
            Point pixel1 = pointToPixel(x1, y1);
            Point pixel2 = pointToPixel(x2, y2);
            g.DrawLine(pen, pixel1, pixel2);
        }
        private void moveBall(float x1, float y1)
        {
            Point pixel = pointToPixel(x1, y1);
            palla.Location = pixel;
        }

        private void pianoOnResize(object? sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }

        private void pianoOnMouseMove(object? sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
            coordMouse.Text = String.Format("({0},{1})", mouse_x, mouse_y);

            PointF point = pixelToPoint(mouse_x, mouse_y);
            coordPunto.Text = String.Format("({0:0.00},{1:0.00})", point.X, point.Y);
        }
        

    }
}