using System;
namespace Phone_Asm
{
	public abstract class Phone
	{
        public string Name { get; set; }
        public List<string> PhoneNumber { get; set; }

        public abstract void insertPhone(String name, String phone);
		public abstract void RemovePhone(String name);
		public abstract void UpdatePhone(String name, String newPhone);
		public abstract void SearchPhone(String name);
		public abstract void Sort();
	}
}

