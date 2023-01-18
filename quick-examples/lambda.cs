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
	public static void Main()
	{
		int x=7;
		int y=3;
		int param1 = 10;
		int param2 = 100;
		Operazione[] ops = new Operazione[6];
		ops[0] = new Operazione("Somma1", (c,d) => c+d);
		ops[1] = new Operazione("Sottrazione1", (c,d) => c-d);
		ops[2] = new Operazione("Moltiplicazione1", (int c, int d) => {
			return c*d;
		});
		ops[3] = new Operazione("Divisione1", (int c, int d) => {
			return c/d;
		});
		ops[4] = new Operazione("zero", (int c, int d) => {
			return 0;
		});
		ops[5] = new Operazione("NULL", null);
		
		foreach(var op in ops) {
			Console.WriteLine("Operazione {0} con a={1}, b={2} --> risultato = {3}", op, x,y, op.Calcola(x,y));
		}
	}
}