using System;
namespace Fraction
{
	public class Fraction
	{
		public int tuSo;
		public int mauSo;
		public Fraction()
		{
			tuSo = 0;
			mauSo = 0;
		}

		//nhap phan so
		public void nhapPS()
		{
			string nts = Console.ReadLine();
            tuSo = Convert.ToInt32(nts);
			string nms = Console.ReadLine();
			mauSo = Convert.ToInt32(nms);
		}

		//in phan so
		public void inPS()
		{
			if (tuSo * mauSo < 0)
			{
				Console.WriteLine("Ban da nhap sai cu phap!");
			}
			else
			{
				Console.WriteLine("Phan so ban vua nhap la: " + tuSo + "/" + mauSo);
			}
		}

		//rut gon phan so
		public void rutgonPS()
		{
			int t = tuSo;
			int m = mauSo;
			int ucln = ucLN(t, m);
			t /= ucln;
			m /= ucln;
			Console.WriteLine("Phan so sau khi rut gon la: " +t+ "/" +m);
		}
		//tim uoc chung lon nhat de rut gon phan so
		static int ucLN(int ts, int ms)
		{
			while (ms != 0)
			{
				int dem = ms;
				ms = ts % ms;
				ts = dem;
			}
			return ts;
		}

		//nghich dao phan so
		public void nghichdaoPS()
		{
			Console.WriteLine("Phan so sau khi ngich dao la: " +mauSo+ "/" +tuSo);
		}
    }
}

