using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tervezés
{
	internal class Haromszog : Sokszog
	{
		private double sideB;
		private double sideC;
		private static Random rnd = new Random();

		public Haromszog(double sideA, double sideB, double sideC) : base(sideA)
		{
			this.sideB = sideB;
			this.sideC = sideC;
			if (!isAddressable())
			{
				throw new ArgumentException("A háromszög nem szerkeszthető!");
			}
		}
		public Haromszog() :base(randomSideLength())
		{
			this.sideB = randomSideLength();
			this.sideC = randomSideLength();
			while (!isAddressable())
			{
				this.SideA = randomSideLength();
				this.SideB = randomSideLength();
				this.SideC = randomSideLength();
			}
		}

		public override double SideA
		{
			set
			{
				base.SideA = value;
				if (!isAddressable())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető!", nameof(value));
				}
			}
		}
		public double B
		{
			get => sideB;
			set
			{
				this.sideB = value;
				if (!isAddressable())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető!", nameof(value));
				}
			}
		}
		public double C
		{
			get => sideC;
			set
			{
				this.sideC = value;
				if (!isAddressable())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető!", nameof(value));
				}
			}
		}

		private bool isAddressable()
		{
			return this.SideA + this.SideB > this.sideC
				&& this.SideA + this.SideC > this.SideB
				&& this.SideB + this.SideC > this.SideC;
		}

		private  static int randomSideLength()
		{
			return rnd.Next(5, 16);
		}

		public double SideB { get => sideB; set => sideB = value; }
		public double SideC { get => sideC; set => sideC = value; }

		public override double getPerimiter()
		{
			return SideA + SideB + SideC;
		}
		public override double getArea()
		{
			double s = this.getPerimiter() / 2;
			return Math.Sqrt(s * (s - this.SideA) * (s - this.SideB) * (s - this.SideC));
		}

		public override string ToString()
		{
			return $"Háromszög oldalai\nA:{SideA}	B:{sideB}	C:{SideC}\nKerülete, területe:\n{base.ToString()}";
		}
	}
}
