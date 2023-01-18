using System;
using System.Threading;

public class Program {
	
	public static void Main(String[]args){
		Console.WriteLine("hello World");
	    int[]a =new int[100]; 
		int i=0,somma=0;
		Random rand = new Random();
		
		for(i=0; i<100; i++)
		{
             a[i]=rand.Next(100);
			
		}
		long start = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
		for(i=0; i<100; i++)
		{
			somma=somma+a[i];
			Thread.Sleep(1);
		}
		long end = DateTime.Now.Ticks  / TimeSpan.TicksPerMillisecond;
		long diff = end - start;
		Console.WriteLine("differenza="+diff);
	
		
	}
}