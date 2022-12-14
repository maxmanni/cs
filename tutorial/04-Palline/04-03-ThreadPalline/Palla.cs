using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

        public Pen Pen { get; private set; }

        public Palla (int id, PianoCartesiano piano) : base()
        {
            this.id = id;
            this.piano = piano;

            r = new Random();
            BackColor = GetRandomColor();
            Pen = new Pen(BackColor);
            Size = new Size(20, 20);

            deg = randomAngle();
            rad = toRadiant(deg);
            m = Math.Tan(rad); //m della retta della palla;
            dir = randomDirection();


            Debug.WriteLine("Palla{0}: gradi = {1:0.00}, radianti = {2:0.00}, m = {3:0.00}, direzione={4}, color={5}", id, deg, rad, m, dir, BackColor);

        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private double randomAngle()
        {
            
            float n = r.NextSingle();
            if (n > 0.5f)
            {
                return r.NextDouble() * 90.0f;
            }
            else
            {
                return -r.NextDouble() * 90.0f;
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
            //a:180 = rad:pi --> rad =a*pi/180
            return a * Math.PI / 180.0f;
        }

        public void MoveBall(float x1, float y1)
        {
            Point pixel = piano.PointToPixel(x1, y1);
            Location = pixel;
        }


        private bool hasStarted;
        private float step;
        private void aggiornaPosizione ()
        {
            while (hasStarted)
            {
                if (dir == Direzione.AVANTI)
                {
                    x += step;
                    if (x > piano.Xmax || Y < piano.Ymin || Y > piano.Ymax)
                    {
                        dir = Direzione.INDIETRO;
                    }
                }
                else if (dir == Direzione.INDIETRO)
                {
                    x -= step;
                    if (x < piano.Xmin || Y < piano.Ymin || Y > piano.Ymax)
                    {
                        dir = Direzione.AVANTI;
                    }
                } 
                Thread.Sleep(waitingTime);
            }
           
        }

        private Thread t;
        private int waitingTime;

        public void Start(int waitingTime, float step)
        {
            this.waitingTime = waitingTime;
            this.step = step;
            t = new Thread(new ThreadStart(aggiornaPosizione));
            hasStarted = true;
            t.Start();
        }

        public void Stop ()
        {
            hasStarted = false;
            t.Join();
        }
    }
}
