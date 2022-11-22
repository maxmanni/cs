using System.Drawing.Drawing2D;

namespace Project2_Graphics
{
    public partial class Form1 : Form
    {
        private readonly Pen blackPen;
        private readonly Pen[] colorPens = new Pen[10];
        private float scaleFactor = 1.0f;
        private float scaleFactorStep = 1.25f;
        private float step = 0.05f;

        float xmin = -5.0f, xmax = 5.0f, ymin = -5.0f, ymax = 5.0f;
        int mouse_x, mouse_y;
        int w, h;

        public Form1()
        {
            InitializeComponent(); //do not delete this line!!! 

            blackPen = new Pen(Color.Black, 1.0f);
            colorPens[0] = new Pen(Color.Red, 1.0f);
            colorPens[1] = new Pen(Color.Blue, 1.0f);
            colorPens[2] = new Pen(Color.Green, 1.0f);
            colorPens[3] = new Pen(Color.Magenta, 1.0f);
            colorPens[4] = new Pen(Color.Brown, 1.0f);
            colorPens[5] = new Pen(Color.LightBlue, 1.0f);
            colorPens[6] = new Pen(Color.Beige, 1.0f);
            colorPens[7] = new Pen(Color.Aquamarine, 1.0f);
            colorPens[8] = new Pen(Color.Coral, 1.0f);
            colorPens[9] = new Pen(Color.Pink, 1.0f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStep.Text = String.Format("{0:0.00}",step);
            pianoCartesiano.Paint += pianoOnPaint;
            pianoCartesiano.Resize += pianoOnResize;
            pianoCartesiano.MouseMove += pianoOnMouseMove;
            pianoCartesiano.MouseWheel += pianoOnMouseWheel;
        }


        private void pianoOnPaint(object? sender, PaintEventArgs e)
        {
            Graphics pg = e.Graphics;
            w = pianoCartesiano.Width;
            h = pianoCartesiano.Height;

            //update the size label
            dimPiano.Text = String.Format("{0}, {1}", w, h);

            //test: draw the diagonal line from top left to bottom right
            //drawLine(pg, blackPen, xmin, ymin, xmax, ymax);

            //draw all the selected functions
            if (drawAxes.Checked)
            {
                drawLine(pg, blackPen, xmin, 0, xmax, 0); // x axis (y=0)
                drawLine(pg, blackPen, 0, ymin, 0, ymax); // y axis (x=0)
            }
            if (drawQuad.Checked)
            {
                float x = xmin;
                while (x < xmax)
                {
                    float y = x * x;//Math.Sin(x / 180.0 * Math.PI);
                    float next_x = x + step;
                    float next_y = next_x * next_x;//Math.Sin(next_x / 180.0 * Math.PI);
                    drawLine(pg, colorPens[0], x, y, next_x, next_y);

                    x += step;
                }
            }
            if (drawSin.Checked)
            {
                float x = xmin;
                while (x < xmax)
                {
                    float y = (float)Math.Sin(x);
                    float next_x = x + step;
                    float next_y = (float)Math.Sin(next_x);
                    drawLine(pg, colorPens[1], x, y, next_x, next_y);

                    x += step;
                }
            }
            if (drawCos.Checked)
            {
                float x = xmin;
                while (x < xmax)
                {
                    float y = (float)Math.Cos(x);
                    float next_x = x + step;
                    float next_y = (float)Math.Cos(next_x);
                    drawLine(pg, colorPens[2], x, y, next_x, next_y);

                    x += step;
                }
            }
            if (drawExp.Checked)
            {
                float x = xmin;
                while (x < xmax)
                {
                    float y = (float)Math.Exp(x);
                    float next_x = x + step;
                    float next_y = (float)Math.Exp(next_x);
                    drawLine(pg, colorPens[3], x, y, next_x, next_y);

                    x += step;
                }
            }
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

        private void drawLine(Graphics graphics, Pen pen, float x1, float y1, float x2, float y2)
        {
            Point pixel1 = pointToPixel(x1, y1);
            Point pixel2 = pointToPixel(x2, y2);
            graphics.DrawLine(pen, pixel1, pixel2);
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
        private void pianoOnMouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                scaleFactor /= scaleFactorStep; // zoom out --> reduce zoom, increment xmin, xmax
                xmin /= scaleFactorStep;
                xmax /= scaleFactorStep;
                ymin /= scaleFactorStep;
                ymax /= scaleFactorStep;
            }
            else
            {
                scaleFactor *= scaleFactorStep; // zoom in --> increase zoom, reduce xmin, xmax
                xmin *= scaleFactorStep;
                xmax *= scaleFactorStep;
                ymin *= scaleFactorStep;
                ymax *= scaleFactorStep;
            }

            txtZoom.Text = String.Format("zoom={0:0.0}x", 1/scaleFactor);
            pianoCartesiano.Invalidate();
        }

        private void drawQuad_CheckedChanged(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }

        private void drawExp_CheckedChanged(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }


        private void drawAxes_CheckedChanged(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }

        private void drawSin_CheckedChanged(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }

        private void drawCos_CheckedChanged(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Single.TryParse(txtStep.Text, out float new_step_value))
            {
                step = new_step_value;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            pianoCartesiano.Invalidate();
        }
    }
}