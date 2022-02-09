using System;
using ConsoleApp5.Core;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Model model = new Model();

			Console.WriteLine(model.Value);
			Console.WriteLine(Model.VALUE);

			Console.ReadKey();

		}
	}
}
