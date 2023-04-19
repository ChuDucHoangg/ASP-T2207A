using System;
namespace T2207A
{
	public class Student
	{
		private string name;
        private string email;
        private int age;
        private string telephone;

        public Student()
		{
			this.Run();
		}
		public Student(string name, string email, int age, string telephone)
		{
			this.name = name;
			this.email = email;
			this.age = age;
			this.telephone = telephone;
        }

		public string Name // property
		{
			get { return this.name; }
			set { this.name = value; }
		}
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
		public int Age
		{
			get => this.age;
			set => this.age = value;
        }
        public string Telephone
        {
            get => this.telephone;
            set => this.telephone = value;
        }

        public virtual void Run()
		{
			Console.WriteLine(this.name + "Running ... ");
		}

		public void Learn()
		{
			Console.WriteLine("Learning ... ");
		}
	}
}

