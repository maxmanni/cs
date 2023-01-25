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
			int j = i; //questa variabile esiste solo all'interno del for: viene creata una j diversa (= diversa locazione di memoria) ad ogni iterazione. La j precedente verrebbe buttata via dal gestore della memoria del C#, se nessuno puntasse più a lei. Siccome però viene catturata dal thread sotto, allora non la può buttare finché l'oggetto thread stesso non viene eliminato dalla memoria.  
			vt[i] = new Thread(()=>stampa(j)); // j catturata dal main per valore (si copia x=j)
		}
		
		for(i=0; i<n; i++) {
			vt[i].Start(); //faccio partire tutti i thread: possono ovviamente essere schedulati ed eseguiti in disordine, non lo possiamo controllare (è una decisione dello scheduling dei processi del sistema operativo), per cui vedremo stampe delle x in ordine non necessariamente crescente, ma comunque tutte diverse (verificare con un n piccolo)
		}
		
		for(i=0; i<n; i++) {
			vt[i].Join();	//aspetto che tutti i thread abbiano finito
		}
		
	}
}