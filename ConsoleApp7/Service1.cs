using System;

namespace ConsoleApp7
{
	public sealed class Service1
	{

		private readonly Service2 service2;

		public Service1(Service2 service2)
		{
			this.service2 = service2;
		}

		public void DoWork()
		{
			service2.DoWork();
		}

		public void Print(String message)
		{
			Console.WriteLine(message);
		}

	}
}