using System;

namespace ConsoleApp8
{
	public sealed class Model : IObject, IService
	{
		void DoWork()
		{
			Console.WriteLine(nameof(IObject));
		}

		void DoWork()
		{
			Console.WriteLine(nameof(IService));
		}

	}
}