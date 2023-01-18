using System;

public abstract class Operazione {
	private string name;
	public abstract int Calcola(int a, int b);
	
	public Operazione (string name) {
		this.name = name;
	}
	public override string ToString() {
		return name;
	}
}

public class Somma : Operazione {
	
	public Somma(string name) : base(name) {
	}
	
	public override int Calcola(int a, int b) {
		return a+b;
	}
}

public class Sottrazione : Operazione {
	
	public Sottrazione(string name) : base(name) {
	}
	
	public override int Calcola(int a, int b) {
		return a-b;
	}
}

public class Moltiplicazione : Operazione {
	
	public Moltiplicazione(string name) : base(name) {
	}
	
	public override int Calcola(int a, int b) {
		return a*b;
	}
}

public class Divisione : Operazione {
	
	public Divisione(string name) : base(name) {
	}
	
	public override int Calcola(int a, int b) {
		return a/b;
	}
}
					
public class Program
{
	public static void Main()
	{
		int x=7;
		int y=3;
		Operazione[] ops = new Operazione[4];
		ops[0] = new Somma("Somma1");
		ops[1] = new Sottrazione("Sottrazione1");
		ops[2] = new Moltiplicazione("Moltiplicazione1");
		ops[3] = new Divisione("Divisione1");
		
		foreach(var op in ops) {
			Console.WriteLine("Operazione {0} con a={1}, b={2} --> risultato = {3}", op, x,y, op.Calcola(x,y));
		}
	}
}