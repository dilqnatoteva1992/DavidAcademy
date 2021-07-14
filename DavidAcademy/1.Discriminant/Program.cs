using System;

namespace _1.DiscriminantOfTheQuadraticRoot
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b, c;
			Console.WriteLine("Please enter the variable `a`");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the variable `b`");
			b = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the variable `c`");
			c = double.Parse(Console.ReadLine());

			double discriminat = Math.Sqrt(b) - 4 * a * c;
			Console.WriteLine($"The discriminant is: {discriminat}");
		}
	}
}
