namespace Electrecity;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap 1 neu khach hang la nguoi viet, Nhap 2 neu khach hang la nguoi nuoc ngoai!");
        int menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
            case 1:
                PeoPleVN vn = new PeoPleVN();
                vn.nhapThongTin();
                vn.inThongTin();
                break;

            case 2:
                PeoPleNN nn = new PeoPleNN();
                nn.nhapThongTin();
                nn.inThongTin();
                break;
        }
    }
}

