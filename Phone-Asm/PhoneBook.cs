using System;
namespace Phone_Asm
{
	public class PhoneBook : Phone
	{
        public List<PhoneBook> PhoneList = new List<PhoneBook>();

        public override void insertPhone(string name, string phone)
        {
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i].Name.Equals(name))
                {
                    if (PhoneList[i].PhoneNumber.Contains(phone))
                    {
                        PhoneList[i].PhoneNumber.Add(phone);
                        Console.WriteLine("Them so dien thoai thanh cong");
                    }
                    else
                    {
                        Console.WriteLine("So dien thoai da ton tai");
                    }
                    return;
                }
            }
            PhoneList.Add(new PhoneBook { Name = name, PhoneNumber = new List<string> { phone } });
            Console.WriteLine("Them moi danh ba thanh cong");
        }

        public override void RemovePhone(string name)
        {
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i].Name.Equals(name))
                {
                    PhoneList.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong");
                    return;
                }
            }
            Console.WriteLine("Khong tim thay ten nguoi dung trong danh ba");
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            bool found = false;
            foreach (Phone phone in PhoneList)
            {
                if (phone.Name.Equals(name))
                {
                    phone.PhoneNumber.Clear();
                    phone.PhoneNumber.Add(newPhone);
                    Console.WriteLine("Cap nhap so dien thoai thanh cong");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay ten trong danh ba");
            }
        }

        public override void SearchPhone(string name)
        {
            var contacts = PhoneList.Where(p => p.Name.Equals(name));
            if (contacts.Count() == 0)
            {
                Console.WriteLine("khong tim thay danh ba lien lac");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Ten: {contact.Name}\tSo dien thoai: {string.Join(", ", contact.PhoneNumber)}");
                }
            }
        }

        public override void Sort()
        {
            PhoneList.Sort((a, b) => a.Name.CompareTo(b.Name));
        }
    }
}

