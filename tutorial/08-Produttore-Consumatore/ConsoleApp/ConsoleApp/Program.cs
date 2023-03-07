using System;

namespace ConsoleApp
{
    internal class Program
    {
        static int n = 10;
        static int[] v = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int ultimo = -1;
        static Random r = new Random();

        static void stampa()
        {
            Console.Write("Stampa v[] = ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", v[i]);
            }
            Console.WriteLine();
        }

        public void produci()
        {
            ultimo++;
            v[ultimo] = r.Next(5);
            Console.WriteLine("Prodotto v[{0}]={1}", ultimo, v[ultimo]);
        }

        public void consuma()
        {
            int letto = v[ultimo];
            Console.WriteLine("Consumato v[{0}]={1}", ultimo, v[ultimo]);
            v[ultimo] = 0;
            ultimo--;
        }


        public static void Main()
        {

            Thread t1, t2, t3;
            t1 = new Thread(() =>
            {
                while (true)
                {
                    stampa();
                    Thread.Sleep(100);
                }
            });

            t1.Start();

            
    
        }

    }
}