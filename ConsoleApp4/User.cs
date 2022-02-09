using System;

namespace ConsoleApp4
{
	public sealed class User
	{
		
		public String Name { get; set; }

		public User(String name)
		{
			Name = name;
		}

		public override String ToString() => Name;

	}
}