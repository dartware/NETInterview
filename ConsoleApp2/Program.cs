using System;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Pet pet = new Pet()
			{
				Name = "Барсик"
			};

			Console.WriteLine(pet.Name);

		}
	}
}
