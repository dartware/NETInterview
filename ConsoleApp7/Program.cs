using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			IServiceCollection services = new ServiceCollection();

			services.AddSingleton<Service1>();
			services.AddSingleton<Service2>();

			ServiceProvider serviceProvider = services.BuildServiceProvider();
			Service2 service2 = serviceProvider.GetService<Service2>();

			service2.DoWork();

		}
	}
}
