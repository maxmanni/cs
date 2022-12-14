using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Graphics
{
    internal class Palla : PictureBox
    {
        int id;
        Random r;
        Direzione dir;
        private double x = 0, y = 0; //coordinate palla
        private double m, q; //m e q della retta della palla y = mx+q

        private double deg, rad;

        PianoCartesiano piano;

        public double X
        {
            get { return x; }
        }

        public double Y { 
            get { return m * x + q; } 
        }

        public Palla (int id, PianoCartesiano piano) : base()
        {
            this.id = id;
            this.piano = piano;

            r = new Random();
            BackColor = GetRandomColour();
            Size = new Size(20, 20);

            deg = randomAngle();
            rad = toRadiant(deg);
            m = Math.Tan(rad); //m della retta della palla;
            dir = randomDirection();


            Console.WriteLine("Palla{0}: gradi = {1:0.00}, radianti = {2:0.00}, m = {3:0.00}, direzione={4}", id, deg, rad, m, dir);
        }

        private Color GetRandomColour()
        {
            return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private double randomAngle()
        {
            
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

        public void MoveBall(float x1, float y1)
        {
            Point pixel = piano.PointToPixel(x1, y1);
            Location = pixel;
        }

        public void AggiornaPosizione ()
        {
            if (dir == Direzione.AVANTI)
            {
                x += piano.Step;
                if (x > piano.Xmax)
                {
                    dir = Direzione.INDIETRO;
                }
            }
            else if (dir == Direzione.INDIETRO)
            {
                x -= piano.Step;
                if (x < piano.Xmin)
                {
                    dir = Direzione.AVANTI;
                }
            }
        }

    }
}
