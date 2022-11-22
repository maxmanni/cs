namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
            piano.Paint += pianoOnPaint;
            piano.Resize += pianoOnResize;
            //piano.MouseMove += pianoOnMouseMove;
            //piano.MouseWheel += pianoOnMouseWheel;
        }

        private void pianoOnResize(object? sender, EventArgs e)
        {
            piano.Invalidate();
        }

        private void pianoOnPaint(object? sender, PaintEventArgs e)
        {
            Graphics pg = e.Graphics;
            int w = piano.Width;
            int h = piano.Height;

            //pg.Clear(piano.BackColor);
            if (clicked)
            {
                pg.DrawLine(Pens.Red, 0, 0, w, h);
                clicked = false;
            }
            
        }

        bool clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            clicked = true;
            piano.Invalidate();
        }

    }
}