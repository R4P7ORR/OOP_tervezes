using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tervezés
{
	internal abstract class Sokszog
	{
		private double sideA;

		public Sokszog(double sideA)
		{
			this.sideA = sideA;
		}

		public double SideA { get => sideA; set => sideA = value; }

		public abstract double getPerimiter();
		public abstract double getArea();

		public override string ToString()
		{
			return $"K:{this.getPerimiter()}	-	T:{this.getArea()}\n------------------------";
		}
	}
}
