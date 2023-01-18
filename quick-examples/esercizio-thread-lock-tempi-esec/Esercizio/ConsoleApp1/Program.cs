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
    const int N = 10000; //dimensione dei dati

    public static void Main(String[] args)
    {
        Console.WriteLine("hello World");
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
        Cronometro tSomma1 = new Cronometro("Somma1");
        tSomma1.Start();
        somma = 0;
        for (i = 0; i < N; i++)
        {
            somma += a[i];
            //Thread.Sleep(1);
        }
        tSomma1.End();
        Console.WriteLine(tSomma1);
        Util.Pause();



        Console.WriteLine("\nSomma eseguita con due thread, su parti indipendenti");
        //TODO
        Util.Pause();
    }
}