using System;

public class Operazione {
	private string name;
	private Func<int, int, int> operazione;
	
	public int Calcola(int a, int b) {
		if (operazione != null) {
			return operazione(a,b);
		} else {
			return -1;
		}
	}
	
	public Operazione (string name, Func<int, int, int> operazione) {
		this.name = name;
		this.operazione = operazione;
	}
	public override string ToString() {
		return name;
	}
}
					
public class Program
{
	public static int m(int a, int b) {
		return a+b+1000;
	}
	
	public static void Main()
	{
		int x=7;
		int y=3;
		int param1 = 10;
		int param2 = 100;
		
		Operazione[] ops = new Operazione[10];
		ops[0] = new Operazione("Somma1", (c,d) => c+d);	//lambda expression
		ops[1] = new Operazione("Sottrazione1", (c,d) => c-d);
		ops[2] = new Operazione("Moltiplicazione1", (int c, int d) => { //lamba statement
			return c*d;
		});
		ops[3] = new Operazione("Divisione1", (int c, int d) => {
			return c/d;
		});
		ops[4] = new Operazione("Zero", (int c, int d) => {
			return 0;
		});
		ops[5] = new Operazione("NULL", null); //null lambda
		ops[6] = new Operazione("Somma2", (int c, int d) => {
			return c*param1 + d*param2; //param1, param2 are called "captured variables"
		});
		ops[7] = new Operazione("m", m); //passing a normal method / function
		
		Func<int, int, int> f = (int h, int k) => { //;lambda expression can be assigned to a variable of type Func
			return h*k;
		};
		ops[8] = new Operazione("f", f); //passing a normal method / function
		
		Func<int, int, int> g = (int h, int k) => {
			return h*k*param1*param2; //also in this case param1 and param2 are "captured variables"
		};
		ops[9] = new Operazione("g", g); //passing a normal method / function
		
		foreach(var op in ops) {
			int ris = op.Calcola (x,y);
			Console.WriteLine("Operazione {0} con a={1}, b={2} --> risultato = {3}", op, x,y, ris);
		}
	}
}