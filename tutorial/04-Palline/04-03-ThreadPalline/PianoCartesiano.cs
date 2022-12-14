using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Graphics
{

    internal class PianoCartesiano
    {

        public float Xmin {get; private set; }  
        public float Xmax { get; private set; }
        public float Ymin { get; private set; }
        public float Ymax { get; private set; }

        int w, h;

        public PianoCartesiano()
        {
            Xmin = -5.0f;
            Xmax = 5.0f;
            Ymin = -5.0f;
            Ymax = 5.0f;
        }

        public void SetSize (int w, int h)
        {
            this.w = w;
            this.h = h;
        }

        public PointF PixelToPoint(int px, int py)
        {
            float fx = (float)px / (float)w; // fx in the interval [0 ; 1] from left to right
            float fy = 1.0f - (float)py / (float)h; // fy in the interval [0 ; 1] from bottom to top
            return new PointF(Xmin + (Xmax - Xmin) * fx, Ymin + (Ymax - Ymin) * fy);
        }

        public Point PointToPixel(float x, float y)
        {
            float fx = (x - Xmin) / (Xmax - Xmin);
            float fy = (y - Ymin) / (Ymax - Ymin);
            return new Point((int)(fx * (float)w), (int)((1.0f - fy) * (float)h));
        }

        public void DrawLine(Graphics g, Pen pen, float x1, float y1, float x2, float y2)
        {
            Point pixel1 = PointToPixel(x1, y1);
            Point pixel2 = PointToPixel(x2, y2);
            g.DrawLine(pen, pixel1, pixel2);
        }
    }
}
