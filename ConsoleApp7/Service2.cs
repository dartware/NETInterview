namespace ConsoleApp7
{
	public sealed class Service2
	{

		private readonly Service1 service1;

		public Service2(Service1 service1)
		{
			this.service1 = service1;
		}

		public void DoWork()
		{
			service1.Print("Привет, Мир.");
		}

	}
}