using System;
using System.Threading;

public class Program {
	
	public static void stampa(int x) {
		Console.WriteLine("x = {0}", x);
	}
	
	//Eseguimi su https://dotnetfiddle.net/ o in un progetto Console Application in VS2022
	public static void Main(String[] args){
		int i;
		int n=100;
		Thread[] vt = new Thread[n];
		
		for(i=0; i<n; i++) {
			vt[i] = new Thread(()=>stampa(i)); // i catturata dal main per riferimento
		}
		
		for(i=0; i<n; i++) {
			vt[i].Start();
			//vt[i].Join(); //notare la differenza scommentando questa linea
		}
		
		for(i=0; i<n; i++) {
			vt[i].Join();
		}
		
	}
}