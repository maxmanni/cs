using System;
using System.Globalization;
using System.Threading;

public class Cronometro
{
    long start;
    long end;
    readonly string name;

    public Cronometro(string name)
    {
        this.name = name;
    }

    public void Start()
    {
        start = DateTime.Now.Ticks;
        end = start;
    }
    public void End()
    {
        end = DateTime.Now.Ticks;
    }

    public override string ToString()
    {
        var elapsedSpan = new TimeSpan(end - start); 
        return string.Format(CultureInfo.InvariantCulture, "{0}: {1:N3} ms", name, elapsedSpan.TotalMilliseconds);
    }
}


public static class Util
{
    public static void Pause()
    {
        Console.WriteLine("Premi un tasto per continuare...");
        Console.ReadLine();
    }
}


public class Program
{
    const int N = 1000000; //dimensione dei dati

    public static void Main(String[] args)
    {
        int[] a = new int[N];
        int i = 0, somma = 0;
        Random rand = new Random();


        Cronometro tRiempimento = new Cronometro("Riempimento");
        tRiempimento.Start();
        for (i = 0; i < N; i++)
        {
            a[i] = rand.Next(100);
           
        }
        tRiempimento.End();
        Console.WriteLine(tRiempimento);


        Console.WriteLine("\nSomma eseguita con un solo thread");
        Cronometro cron1 = new Cronometro("cron1");
        cron1.Start();
        somma = 0;
        for (i = 0; i < N; i++)
        {
            somma += a[i];
            //Thread.Sleep(1);
        }
        cron1.End();
        Console.WriteLine("somma = " + somma);
        Console.WriteLine(cron1);
        Util.Pause();



        Console.WriteLine("\nSomma eseguita con due thread, su parti indipendenti");
        int somma1 = 0;
        int somma2 = 0;
        Thread t1 = new Thread(() =>
        {
            Cronometro cronThread1 = new Cronometro("cronThread1");
            cronThread1.Start();
            int i;
            for (i = 0; i < N/2; i++)
            {
                somma1 += a[i];
                //Thread.Sleep(1);
            }
            cronThread1.End();
            Console.WriteLine(cronThread1);
        });
        Thread t2 = new Thread(() =>
        {
            Cronometro cronThread2 = new Cronometro("cronThread1");
            cronThread2.Start();
            int i;
            for (i = N/2; i < N; i++)
            {
                somma2 += a[i];
                //Thread.Sleep(1);
            }
            cronThread2.End();
            Console.WriteLine(cronThread2);
        });

        //faccio partire i thread e il cronometro
        Cronometro cron2 = new Cronometro("cron2");
        cron2.Start();
        t1.Start();
        t2.Start();

        //il main aspetta che finiscano tutti e due i thread
        t1.Join();
        t2.Join();
        cron2.End();

        Console.WriteLine("somma = {0}", somma);
        Console.WriteLine("somma1 + somma2 = {0}", somma1+somma2);
        Console.WriteLine(cron2);
        Util.Pause();
    }
}