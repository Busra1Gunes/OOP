using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
	public class MyList<T>  /*where T : class*/
	{
		T[] items;
		//constructor class'ı newlediğimizde otomotik çalışan metottur
		public MyList()
		{
			//dizinin eleman sayısını belirlemek için new'lememiz gerekir 
			items = new T[0];
		}

		public void Add(T item)
		{
			T[] tempArray = items; 
			items=new T[tempArray.Length+1];
			for (int i = 0; i < tempArray.Length; i++)
			{
				items[i] = tempArray[i];
			}
			items[items.Length-1] = item;

		}
	}
}
