using OOP_tervezés;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tervezes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Haromszog h1 = new Haromszog();
			Haromszog h2 = new Haromszog(3, 4, 5);
			Teglalap t1 = new Teglalap(3, 5);
			Teglalap t2 = new Teglalap(4, 2);

            Console.WriteLine(h1);
            Console.WriteLine(h2);
			Console.WriteLine(t1);
			Console.WriteLine(t2);

            /*Console.WriteLine(h2.SideA);
			try
			{
				h2.SideA = 10;
			}
			catch (ArgumentException ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(h2.SideA);*/
            Console.WriteLine("\n\n");
			Paralelogramma p1 = new Paralelogramma();
			Console.WriteLine(p1);


            Console.ReadKey();
		}
	}
}
