using System;

namespace ConsoleApp4
{
	internal class Program
	{

		static void Main(string[] args)
		{

			User user = new User("Bill Gates");

			Print(user);

			Int32 age = 66;

			Print(age);

			Change(user);
			Change(age);

			Print(user);
			Print(age);

		}

		static void Print(User user)
		{
			Console.WriteLine(user);
		}

		static void Print(Int32 age)
		{
			Console.WriteLine(age);
		}

		static void Change(User user)
		{
			user.Name = "Steve Jobs";
		}

		static void Change(Int32 age)
		{
			age = 35;
		}

	}
}
