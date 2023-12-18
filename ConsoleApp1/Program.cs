using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число a: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите число b: ");
			int b = int.Parse(Console.ReadLine());

			int c = a + b;
			Console.WriteLine("Сумма чисел равна: " + c);

		}
	}
}
