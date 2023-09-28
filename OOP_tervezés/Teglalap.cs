using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tervezés
{
	internal class Teglalap : Sokszog
	{
		private double sideB;

		public Teglalap(double sideA, double sideB) : base(sideA)
		{
			this.sideB = sideB;
		}

		public double SideB { get => sideB; set => sideB = value; }

		public override double getPerimiter()
		{
			return 2 * (SideA + sideB);
		}

		public override double getArea()
		{
			return this.SideA * this.SideB;
		}

		public override string ToString()
		{
			return $"Téglalap oldalai\nA:{SideA}	B:{sideB}\nKerülete, területe:\n{base.ToString()}";
		}
	}
}
