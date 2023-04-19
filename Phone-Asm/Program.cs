namespace Phone_Asm;
class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Chon chuc nang:");
            Console.WriteLine("1. Them so dien thoai");
            Console.WriteLine("2. Xoa so dien thoai");
            Console.WriteLine("3. Cap nhap so dien thoai");
            Console.WriteLine("4. Tim kiem so dien thoai");
            Console.WriteLine("5. Sap xep danh ba");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    isRunning = false;
                    break;
                case 1:
                    Console.WriteLine("Nhap ten nguoi dung:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Nhap so dien thoai:");
                    string phone = Console.ReadLine();
                    phoneBook.insertPhone(name, phone);
                    break;
                case 2:
                    Console.WriteLine("Nhap ten nguoi dung muon xoa:");
                    string nameToRemove = Console.ReadLine();
                    phoneBook.RemovePhone(nameToRemove);
                    break;
                case 3:
                    Console.WriteLine("Nhap ten nguoi dung muon cap nhap so dien thoai:");
                    string nameToUpdate = Console.ReadLine();
                    Console.WriteLine("Nhap so dien thoai moi:");
                    string newPhone = Console.ReadLine();
                    phoneBook.UpdatePhone(nameToUpdate, newPhone);
                    break;
                case 4:
                    Console.WriteLine("Nhap ten nguoi dung muon tim kiem:");
                    string nameToSearch = Console.ReadLine();
                    phoneBook.SearchPhone(nameToSearch);
                    break;
                case 5:
                    phoneBook.Sort();
                    Console.WriteLine("Danh ba da duoc sap xep theo ten!");
                    for (int i = 0; i < phoneBook.PhoneList.Count; i++)
                    {
                        Console.WriteLine($"Ten: {phoneBook.PhoneList[i].Name}");
                        Console.WriteLine($"So dien thoai: {string.Join(", ", phoneBook.PhoneList[i].PhoneNumber)}");
                    }
                    break;
                default:
                    Console.WriteLine("Chuc nang khong ton tai!");
                    break;
            }
        }
    }
}

