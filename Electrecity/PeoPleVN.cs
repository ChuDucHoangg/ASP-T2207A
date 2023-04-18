using System;
using System.Globalization;

namespace Electrecity
{
    public class PeoPleVN
    {
        private int maKH;
        private string hoTen;
        private string hoaDon;
        private string doiTuong;
        public double soLuong;
        public double donGia;
        public double dinhMuc;
        public double donGiaMoi;

        public PeoPleVN()
        {
        }

        public PeoPleVN(int maKH, string hoTen, string hoaDon, string doiTuong, double soLuong, double donGia,double dinhMuc, double donGiaMoi)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.hoaDon = hoaDon;
            this.doiTuong = doiTuong;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.dinhMuc = dinhMuc;
            this.donGiaMoi = donGiaMoi;
        }

        public double ThanhTien(double soLuong, double donGia)
        {
            double dinhMuc = 0;
            double donGiaMoi = 0;

            if (doiTuong == "sinh hoat")
            {
                if (soLuong <= 50)
                {
                    dinhMuc = 50;
                    donGiaMoi = 1000;
                }
                else if (soLuong <= 100 && soLuong > 50)
                {
                    dinhMuc = 100;
                    donGiaMoi = 1200;
                }
                else if (soLuong <= 200 && soLuong > 100)
                {
                    dinhMuc = 200;
                    donGiaMoi = 1500;
                }
                else
                {
                    dinhMuc = 0;
                    donGiaMoi = 2000;
                }
            }
            else //kinh doanh san xuat
            {
                dinhMuc = 0;
                donGiaMoi = 2000;
            }

            double thanhTien = 0;
            if (soLuong <= dinhMuc)
            {
                thanhTien = soLuong * donGia;
            }
            else
            {
                thanhTien = dinhMuc * donGia + (soLuong - dinhMuc) * donGiaMoi;
            }
            return thanhTien;
        }

        public void nhapThongTin()
		{
			Console.WriteLine("Nhap ID khach: ");
			string nhapID = Console.ReadLine();
			maKH = Convert.ToInt32(nhapID);

			Console.WriteLine("Nhap ho ten khach hang: ");
            string nhapName = Console.ReadLine();
			this.hoTen = nhapName;

			Console.WriteLine("Nhap ngay ra hoa hon (dd/mm/yyyy): ");
            string nhapDate = Console.ReadLine();
            this.hoaDon = nhapDate;
			

			Console.WriteLine("Chon doi tuong khach hang(1.SINH HOAT, 2.KINH DOANH, 3.SAN XUAT): ");
			int doiTuong = int.Parse(Console.ReadLine());
            if (doiTuong == 1)
            {
                this.doiTuong = "sinh hoat";
            }
            else if (doiTuong == 2)
            {
                this.doiTuong = "kinh doanh";
            }
            else if (doiTuong == 3)
            {
                this.doiTuong = "san xuat";
            }

            Console.WriteLine("nhap so luong su dung: ");
		    soLuong = double.Parse(Console.ReadLine());

            if (soLuong <= dinhMuc)
            {
                donGia = donGiaMoi;
            }
            else
            {
                Console.WriteLine("Don gia: ");
                donGia = double.Parse(Console.ReadLine());
            }
        }

		public void inThongTin()
		{
			Console.WriteLine("ID khach hang: " + maKH);
			Console.WriteLine("Ho ten khach hang: " + hoTen);
			Console.WriteLine("Ngay ra hoa don: " + hoaDon);
			Console.WriteLine("Doi tuong khach hang: " + doiTuong);
            Console.WriteLine("So KW su dung: " + soLuong);
			Console.WriteLine("Don gia: " + donGia);
			Console.WriteLine("Thanh tien: " + ThanhTien(soLuong, donGia));

        }
    }
}

