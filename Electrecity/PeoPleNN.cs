using System;
namespace Electrecity
{
	public class PeoPleNN
	{
		private int maKH;
		private string hoTen;
		private string hoaDon;
		private string quocTich;
		private double soLuong;
		private double donGia;

		public PeoPleNN()
		{
		}

		public PeoPleNN(int maKH, string hoTen, string hoaDon, string quocTich, double soLuong, double donGia)
		{
			this.maKH = maKH;
			this.hoTen = hoTen;
			this.hoaDon = hoaDon;
			this.quocTich = quocTich;
			this.soLuong = soLuong;
			this.donGia = donGia;
		}

		public double ThanhTien()
		{
			double thanhTien = soLuong * donGia;
			//thanhTien = soLuong * donGia;
			return thanhTien;
		}

		public void nhapThongTin()
		{
			Console.WriteLine("Nhap id khach hang: ");
			string nhapID = Console.ReadLine();
			maKH = Convert.ToInt32(nhapID);

			Console.WriteLine("Nhap ho ten khach hang: ");
			string nhapTen = Console.ReadLine();
			this.hoTen = nhapTen;

			Console.WriteLine("Nhap ngay ra hoa don(dd/mm/yyyy): ");
			string nhapHD = Console.ReadLine();
			this.hoaDon = nhapHD;

			Console.WriteLine("Nhap quoc tich khach hang: ");
			string nhapQT = Console.ReadLine();
			this.quocTich = nhapQT;

			Console.WriteLine("Nhap so luong KW: ");
            soLuong = double.Parse(Console.ReadLine());

			Console.WriteLine("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());
        }

        public void inThongTin()
        {
            Console.WriteLine("ID khach hang: " + maKH);
            Console.WriteLine("Ho ten khach hang: " + hoTen);
            Console.WriteLine("Ngay ra hoa don: " + hoaDon);
            Console.WriteLine("Quoc tich khach hang: " + quocTich);
            Console.WriteLine("So KW su dung: " + soLuong);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Thanh tien: " + ThanhTien());

        }
    }
}

