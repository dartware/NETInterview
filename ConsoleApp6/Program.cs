using System;
using System.IO;

namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Int32[] array = { 10, 20, 30, 40 };

			StreamWriter writer = new StreamWriter("File.txt");

			foreach (Int32 value in array)
			{
				writer.WriteLine(value.ToString());
			}

		}
	}
}
