/*
 * 
 * In this example, we create an instance of Counter and 1000 threads that each increment 
the count field. However, because multiple threads are accessing and modifying the 
shared count field concurrently, there is a possibility that the final count may not 
be exactly 1000. This is because the increment operation (count++) is not atomic, 
meaning that it is not guaranteed to be completed in a single indivisible operation. 
As a result, there is a possibility that two threads could both read the same value of 
count, increment it, and write the new value back, resulting in only one increment 
being performed instead of two.

To avoid this type of concurrency issue, you can use a lock or other synchronization 
mechanism to ensure that only one thread can access the shared resource at a time.
*/

using System.Threading;

class Counter
{
    private int count = 0;

    public void Increase()
    {
        count++;
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

