using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tervezés
{
	internal class Paralelogramma : Teglalap
	{
		private double alpha;
		private double sideB;
		private static Random rnd = new Random();

		public double Alpha { get => alpha; set => alpha = value; }

		public Paralelogramma() :base(randomSideLength(), randomSideLength())
		{
			this.alpha = randomSideLength();
		}

		public Paralelogramma(double sideA, double sideB, double alpha) : base(sideA, sideB)
		{
			this.alpha =alpha;
		}

		private static int randomSideLength()
		{
			return rnd.Next(1, 200);
		}
		public override double getArea()
		{
			return this.SideA * this.SideB * Math.Round(Math.Sin(alpha/180 * Math.PI), 2);
		}

		public override string ToString()
		{
			return $"Alfa szög: {this.alpha}\nKerület: {getPerimiter()}	Terület:{this.getArea()}";
		}
	}
}
