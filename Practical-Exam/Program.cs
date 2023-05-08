namespace Practical_Exam;
class Program
{
    static void Main(string[] args)
    {
        Products p = new Products();

        while (true)
        {
            Console.WriteLine("Choose method: ");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Display product");
            Console.WriteLine("3. Delete product");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choose: ");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    p.addProduct();
                    break;

                case "2":
                    p.displayProduct();
                    break;

                case "3":
                    p.deleteProduct();
                    break;
                case "4":
                    return;
            }
        }
    }
}

