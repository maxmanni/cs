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
			vt[i] = new Thread(()=>stampa(i)); // i del main catturata dal main per copia: ma la copia sarà fatta quando il thread parte. Per ora qui è soltanto creato e gli viene detto cosa deve fare, ossia chiamare la funzione stampa passando x=i
		}
		
		for(i=0; i<n; i++) {
			vt[i].Start();	//è qui che la funzione stampa viene chiamata da ciascun thread, catturando il valore della i in quel momento. Siccome i è riutilizzata in questo ciclo, non si può dire che valore assume per ciascun thread: dipende dallo scheduler dei processi del sistema operativo che decide quando eseguire uno dei nuovi thread creati, oppure andare avanti con il ciclo for. Ci possono essere quindi anche valori di i duplicati.
			//Altra osservazione. Se al posto di i, usassi una nuova variabile k per questo ciclo, tutti i thread stamperebbero i=n, ossia il valore di i all'uscita del ciclo precedente
			
			//vt[i].Join(); //notare la differenza scommentando questa linea: prima di creare un nuovo thread, si aspetta che finisca il successivo. In questo caso la stampa dei valori di x=i avverrebbe in ordine, perché ogni thread catturerebbe il valore della i giusto (il for non potrebbe andare avanti in parallelo, si fermerebbe ad aspettare la fine dell'i-esimo thread, prima di far partire l'(i+1)-esimo. 
			//In questo caso, se al posto di i, usassi una nuova variabile k per questo ciclo, tutti i thread stamperebbero di nuovo i=n, ossia il valore di i all'uscita del ciclo precedente (visto che sarebbe il suo valore).
		}
		
		for(i=0; i<n; i++) {
			vt[i].Join();	// prima di terminare il main, aspetto che terminino tutti i processi (se già non sono terminati)
		}
		
	}
}