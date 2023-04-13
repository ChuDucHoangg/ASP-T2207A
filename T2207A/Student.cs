using System;
namespace T2207A
{
	public class Student
	{
		public string name;
		public string email;
		public int age;
		public string telephone;
		public Student()
		{
			this.Run();
		}

		public void Run()
		{
			Console.WriteLine(this.name + "Running ... ");
		}
	}
}

