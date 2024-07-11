using OOP;

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
		productManager.BirseyYap( ref sayi);
		Console.WriteLine(sayi);
		Console.WriteLine(product.ProductName);
		//void metodu ders 3


	}
}