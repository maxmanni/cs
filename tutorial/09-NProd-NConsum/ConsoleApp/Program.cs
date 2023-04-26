using System;
using System.Threading;

namespace ConsoleApp
{
    internal class Program
    {
        const int DIM_BUFFER = 20;

        const int NPROD = 5;
        const int sleepProd = 750;
        const int sleepCons = 700;
        const int sleepStampa = 300;
        const int NCONS = 3;

        static object obj = new object();
        static Semaphore vuoto = new Semaphore(DIM_BUFFER, DIM_BUFFER);
        static Semaphore pieno = new Semaphore(0, DIM_BUFFER);
        static Mutex mutexP = new Mutex(false);
        static Mutex mutexC = new Mutex(false);
        static int metti = 0;
        static int togli = 0;

        static int[] buffer;

        static int contaStampe = 0;
        static int maxStampe = 100;
        static bool stop = false;


        public static void stampa()
        {
            Console.Write("\n stampa {0} buffer = [",contaStampe);
            for (int i = 0; i < DIM_BUFFER; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(buffer[i]);
            }
            Console.Write("]");

            contaStampe++;

            if (contaStampe == maxStampe)
            {
                stop = true;
            }
        }

        public static void produci(int numero)
        {
            int tmp;

            vuoto.WaitOne();

            mutexP.WaitOne();
            tmp = metti;
            metti = (metti + 1) % DIM_BUFFER;
            mutexP.ReleaseMutex();

            buffer[tmp] = numero;
            Console.Write("\nProdotto {0} in posizione {1}", numero, tmp);

            pieno.Release();
        }

        public static void consuma()
        {
            int tmp;

            pieno.WaitOne();

            mutexC.WaitOne();
            tmp = togli;
            togli = (togli + 1) % DIM_BUFFER;
            mutexC.ReleaseMutex();

            Console.Write("\nConsumato {0} in posizione {1}", buffer[tmp], tmp);
            buffer[tmp] = 0;

            vuoto.Release();
        }


        public static void Main()
        {
            //inizializzo tutti gli elementi del buffer a 0
            buffer = new int[DIM_BUFFER];
            for (int i = 0; i < DIM_BUFFER; i++)
            {
                buffer[i] = 0;
            }

            //thread di stampa
            Thread tStampa = new Thread(() =>
            {
                while (!stop)
                {
                    stampa();
                    Thread.Sleep(sleepStampa);
                }
            });
            tStampa.Start();

            //produttori (ognuno produce un numero diverso da 1 a NPROD)
            Thread[] produttori = new Thread[NPROD];
            for (int i = 0; i < NPROD; i++)
            {
                produttori[i] = new Thread((numero) =>
                {
                    while (!stop)
                    {
                        produci((int)numero);
                        Thread.Sleep(sleepProd);
                    }
                });
                produttori[i].Start(i + 1);
                Console.Write("\nCreato produttore {0}", i);
            }

            //consumatori (ognuna rimette a 0 una cella del vettore)
            Thread[] consumatori = new Thread[NCONS];
            for (int i = 0; i < NCONS; i++)
            {
                consumatori[i] = new Thread(() =>
                {
                    while (true)
                    {
                        consuma();
                        Thread.Sleep(sleepCons);
                    }
                });
                consumatori[i].Start();
                Console.Write("\nCreato consumatore {0}", i);
            }

            //il main attende che tutti i produttori e consumatori terminino
            for (int i = 0; i < NPROD; i++)
            {
                produttori[i].Join();
                Console.Write("\nTerminato produttore {0}", i);
            }
            for (int i = 0; i < NCONS; i++)
            {
                consumatori[i].Join();
                Console.Write("\nTerminato consumatore {0}", i);
            }

        }
    }
}