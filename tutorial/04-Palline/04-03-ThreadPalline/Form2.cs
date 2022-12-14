using System.Drawing.Drawing2D;
using System.Globalization;

namespace Project2_Graphics
{
    public enum Direzione
    {
        AVANTI,
        INDIETRO
    }

    public partial class Form2 : Form
    {
        PianoCartesiano piano;
        int mouse_x, mouse_y;

        Palla[]? palline;
        
        Pen drawPen;
        Random r;
        CultureInfo ci = new CultureInfo("en-US");

        public Form2()
        {
            InitializeComponent(); //do not delete this line!!! 
            piano = new PianoCartesiano();
            drawPen = new Pen(ForeColor);
            r = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pannello.Paint += pianoOnPaint;
            pannello.Resize += pianoOnResize;
            pannello.MouseMove += pianoOnMouseMove;
            startButton.Enabled = true;
            stopButton.Enabled = false;

        }

        private void Form1_Close(object? sender, FormClosedEventArgs e)
        {
            eliminaPalle();
        }


        private void pianoOnPaint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            piano.SetSize(pannello.Width, pannello.Height);

            //update the size label
            dimPiano.Text = String.Format("{0}, {1}", pannello.Width, pannello.Height);

            g.Clear(pannello.BackColor); // cancella tutto
            //drawLine(g, Pens.Black, xmin, 0, xmax, 0); // x axis (y=0)
            //drawLine(g, Pens.Black, 0, ymin, 0, ymax); // y axis (x=0)

            //disegna linee di debug
            if (palline != null)
            { 
                foreach (Palla palla in palline)
                {
                    palla.MoveBall((float)palla.X, (float)palla.Y);
                    piano.DrawLine(g, palla.Pen, 0, 0, (float)palla.X, (float)palla.Y);
                }
            }
           
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            int n = Convert.ToInt32(textN.Text);
            float step = Convert.ToSingle(textStep.Text, ci);
            int waitMin = Convert.ToInt32(textWaitMin.Text);
            int waitMax = Convert.ToInt32(textWaitMax.Text);
            timer1.Enabled = true;

            palline = new Palla[n];
            for (int i = 0; i < n; i++)
            {
                Palla p = new Palla(i, piano);
                pannello.Controls.Add(p);
                palline[i] = p;
                p.Start(r.Next(waitMin, waitMax), step);
                labelCount.Text = String.Format("Palle = {0}", i+1);
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            eliminaPalle();
            pannello.Invalidate();
        }

        public void eliminaPalle ()
        {
            timer1.Enabled = false;

            startButton.Enabled = true;
            stopButton.Enabled = false;
            if (palline != null)
            {
                int i = palline.Length - 1;
                while (i>=0)
                {
                    Palla p = palline[i];
                    p.Stop();
                    pannello.Controls.Remove(p);
                    labelCount.Text = String.Format("Palle = {0}", i);
                    i--;
                }

                palline = null;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pannello.Invalidate();
        }


        private void drawAxes_CheckedChanged(object sender, EventArgs e)
        {
            pannello.Invalidate();
        }

       
        

        private void pianoOnResize(object? sender, EventArgs e)
        {
            pannello.Invalidate();
        }


        private void pianoOnMouseMove(object? sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
            coordMouse.Text = String.Format("({0},{1})", mouse_x, mouse_y);

            PointF point = piano.PixelToPoint(mouse_x, mouse_y);
            coordPunto.Text = String.Format("({0:0.00},{1:0.00})", point.X, point.Y);
        }
        

    }
}