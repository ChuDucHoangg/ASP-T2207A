using System;
namespace T2207A
{
	public class Human
	{
		private DateTime birthday;
        public string[] family = new string[3];

        public string this[int index]
        {
            get => family[index];
            set => family[index] = value;
        }
        public DateTime Birthday //popular property
        {
            get => birthday;
            set => birthday = value;
        }

        //abstract property

    }
}

