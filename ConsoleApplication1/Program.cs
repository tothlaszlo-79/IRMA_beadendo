using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomplexSzamitas;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Kérem lentebb adjon meg két komlex számot valós és képzetes formában");
			Console.Write("Az elsö szám valós adattagja:");
			double v1 = Double.Parse(Console.ReadLine());
			Console.Write("Az elsö szám képzetes adattagja:");
			double k1 = Double.Parse(Console.ReadLine());
			Console.Write("A második szám valós adattagja:");
			double v2 = Double.Parse(Console.ReadLine());
			Console.Write("A második szám képzetes adattagja:");
			double k2 = Double.Parse(Console.ReadLine());

            
			var sz1 = new Komplex(v1, k1);
			var sz2 = new Komplex(v2, k2);

			Console.WriteLine("Első komplex szám: " + sz1);
			Console.WriteLine("Második komplex szám:= " + sz2);

			if (sz1 == null)
			{ Console.WriteLine("Az első számpárból nem képzehtő komplex adat!");
				return;
			}
			else if (sz2 == null)
			{ Console.WriteLine("Az második számpárból nem képzehtő komplex adat!");
				return;
			}
			else if (sz1 == sz2)
			{ Console.WriteLine("A két komplex szám egyenlő!");
				var k3 = sz1 + sz2;
				Console.WriteLine("Összegük: " + k3);
				Console.ReadLine();
				return; 
			}			
			else if (sz1 != sz2)
			{ Console.WriteLine("A két komplex szám  nem egyenlő!");
				var k3 = sz1 + sz2;
				Console.WriteLine("Összegük: " + k3);
				Console.ReadLine();
				return;
			}
			
			
            Console.ReadLine();
        }
	}
}
