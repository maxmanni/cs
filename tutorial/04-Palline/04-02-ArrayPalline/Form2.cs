using System.Drawing.Drawing2D;

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
        static int N = 3;
        Palla[] palline = new Palla[N];
        
        Pen drawPen;

        public Form2()
        {
            InitializeComponent(); //do not delete this line!!! 
            piano = new PianoCartesiano();
            drawPen = new Pen(ForeColor);

            for (int i = 0; i < N; i++)
            {
                Palla p = new Palla(i, piano);
                pannello.Controls.Add(p);
                palline[i] = p;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pannello.Paint += pianoOnPaint;
            pannello.Resize += pianoOnResize;
            pannello.MouseMove += pianoOnMouseMove;

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
            foreach (Palla palla in palline)
            {
                palla.MoveBall((float)palla.X, (float)palla.Y);
                piano.DrawLine(g, Pens.Red, 0, 0, (float)palla.X, (float)palla.Y);
            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Palla palla in palline)
            {
                palla.AggiornaPosizione();
            }

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