using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Product
	{
		//prop yazınca kare altında nokta olan bir hazır yapı çıkar buna snippet deriz
        public int Id { get; set; }

		//foreign KEy'i orimary keyden sonra yazmak daha doğru olur
		public int CategoryId { get; set; }
		public string ProductName { get; set; }
        public int UnitPrice { get; set; }
		public int UnitsInStock {  get; set; }


		//CRUD create, read ,update,delete
        

    }
}
