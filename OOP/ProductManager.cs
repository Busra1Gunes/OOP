using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	//Manager ürün ile ilgili operasyonları içerir, CRUD işlemleri
	internal class ProductManager
	{
		//işlem sonucunda işlem sonunucu ile ilgili bilgiye döndürmüyorsak kulanırız

		public void Add(Product product)
		{
			product.ProductName = "kamera";

		}
		public void Update( Product product)
		{
            Console.WriteLine(product.ProductName+ "güncellendi");
        }
		public int Topla(int sayi1, int sayi2)
		{
			return sayi1 + sayi2;
		}
		public void Topla2(int sayi1, int sayi2)
		{
            Console.WriteLine(sayi1 + sayi2 ); 
		}

	}
}
