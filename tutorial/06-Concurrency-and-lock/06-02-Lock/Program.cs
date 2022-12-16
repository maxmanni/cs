using System.Threading;

class Counter
{
    private int count = 0;
    private object lockObject = new object();

    public void Increase()
    {
        lock (lockObject)
        {
            count++;
        }
    }

    public int GetCount()
    {
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var counter = new Counter();
        var threads = new Thread[1000];

        for (int i = 0; i < 1000; i++)
        {
            threads[i] = new Thread(() => counter.Increase());
            threads[i].Start();
        }

        for (int i = 0; i < 1000; i++)
        {
            threads[i].Join();
        }

        Console.WriteLine(counter.GetCount()); // expected output: 1000
    }
}
