using System;
					
public class Program
{
	public static void Main()
	{
		Punto p=new Punto(2,3);
		Punto.x0=5;
		Console.WriteLine(p);
		p.X=1;
		p.Y=1;
		Console.WriteLine(p);
	}
}

class Punto{
	private float x;
	private float y;
	public static float x0=2;
	public  static float y0=2;
	
	public Punto (float x, float y)
	{
		this.x=x;
		this.y=y;
	}
	
	public float X2{
			get{
				return x-x0;
			}
		}
	
	public float Y2{
		get{
			return y-y0;
		}
		}
	
	public float X{
		get
		{ 
			return x;
		}
		set
		{
			x=value;
		}
	}
		public float Y{
		get
		{ 
			return y;
		}
		set
		{
			y=value;
		}
	}
	
	public override string ToString ()
	{
		return string.Format("P({0},{1}) alfa={2} rho={3} P1({4},{5})",x,y, Alfa, Rho, X2, Y2);
	}
	
	public float Alfa
	{
		get
		{
			return Util.converti((float)Math.Atan(y/x));
		}
	}
	public float Rho
	{
		get
		{
			return (float) Math.Sqrt(x*x+y*y);
		}
	}
	
}

public static class Util{
	public static float converti (float radianti){
		return radianti*180/(float)Math.PI;
		}
	}