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
		public void Add(Product product)
		{
			product.ProductName = "kamera";

		}
		public void BirseyYap( ref int sayi)
		{
			sayi = 99;
		}

	}
}
