using System;
namespace Practical_Exam
{
	public class Products
	{
		private string idProduct { get; set; }
		private string nameProduct { get; set; }
		private int priceProduct { get; set; }
        private static List<Products> productList = new List<Products>();

        public Products(string idProduct, string nameProduct, int priceProduct)
		{
			this.idProduct = idProduct;
			this.nameProduct = nameProduct;
			this.priceProduct = priceProduct;
		}

		public Products()
		{
		}

		public void addProduct()
		{
			Console.WriteLine("Enter product ID: ");
			string enterID = Console.ReadLine();
			this.idProduct = enterID;

			Console.WriteLine("Enter product name: ");
			string enterName = Console.ReadLine();
			this.nameProduct = enterName;

			Console.WriteLine("Enter product price: ");
			string enterPrice = Console.ReadLine();
			priceProduct = Convert.ToInt32(enterPrice);

            productList.Add(this);
        }

		public void displayProduct()
		{
            Console.WriteLine("Product ID\tProductName\tPrice");
			foreach (var product in productList)
			{
				Console.WriteLine($"{product.idProduct}\t\t{product.nameProduct}\t\t${product.priceProduct}");
			}
        }

		public void deleteProduct()
		{
			Console.WriteLine("Enter product ID to delete: ");
			string deleteID = Console.ReadLine();

			foreach (var product in productList)
			{
				if (deleteID == idProduct)
				{
					productList.Remove(product);
					Console.WriteLine("Product deleted!");
					return;
				}
				else
				{
					Console.WriteLine("Product not found!");
				}
			}
		}
    }
}

