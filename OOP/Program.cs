using OOP;
using System.Net.NetworkInformation;

class Program
{
	private static void Main(string[] args)
	{
		Product product = new Product();
		product.Id = 1;
		product.ProductName = "";
		product.UnitPrice = 500;
		product.UnitsInStock = 10;
		product.CategoryId = 2;
		Product product1 = new Product { Id=2,ProductName="Kalem",UnitPrice=1,UnitsInStock=5,CategoryId=2};

		//PascalCase     //camelCase 
		ProductManager productManager=new ProductManager();
		productManager.Add(product);
		int sayi = 100;
		//ref yapıldığında metod içindeki sayı değerini atar
		Console.WriteLine(sayi);
		Console.WriteLine(product.ProductName);
		productManager.Topla2(2, 3);
		int sonuc = productManager.Topla(9, 7);
		Console.WriteLine(sonuc);
		//void metodu ders 3


	}
}