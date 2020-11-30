using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexSzamitas
{
    public class Komplex
    {
			/// <summary>
			/// Valós rész
			/// </summary>
			private double Valós;
			/// <summary>
			/// Képzetes rész
			/// </summary>
			private double Képzetes;

			public Komplex(double Valós, double Képzetes)
			{
			
				this.Valós = Valós;
				this.Képzetes = Képzetes;
			
			}

			public override string ToString()
			{
				return Valós+"+i*"+Képzetes;
			}

	        public static Komplex operator +(Komplex a,	Komplex b)
	         {
				return new Komplex(
					a.Valós+b.Valós,
					a.Képzetes+b.Képzetes);
	         }

			public static Komplex operator -(Komplex a, Komplex b)
			{
				return new Komplex(
					a.Valós - b.Valós,
					a.Képzetes - b.Képzetes);
			}

			public static bool operator ==(Komplex a,
				Komplex b)
			{
				if (ReferenceEquals(a, b))
					return true;
				if ((object)a == null || (object)b == null)
					return false;
				return a.Valós == b.Valós &&
							 a.Képzetes == b.Képzetes;
			}

			public static bool operator !=(Komplex a, Komplex b)
			{
				return !(a == b);
			}



	}
}
