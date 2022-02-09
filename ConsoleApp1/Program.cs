using System;

namespace ConsoleApp1
{
	internal class Program
	{
		public static void Main(String[] args)
		{

			DateTime now = DateTime.Now;

			if (now == null)
			{
				throw new NullReferenceException();
			}

			Console.WriteLine(now);

			Int32 price = 100;

			if (price != null)
			{
				Console.WriteLine($"Цена товара: ${price} рублей.");
			}

		}
	}
}