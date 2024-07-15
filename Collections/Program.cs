internal class Program
{
	private static void Main(string[] args)
	{
		//string[] isimler = new string[] {"Büşra", "Kübra","Sena"};
		//Console.WriteLine(isimler[0]);
		//Console.WriteLine(isimler[1]);
		//Console.WriteLine(isimler[2]);
		//isimler = new string[4]; //isimler dizisi için hepad te 4 elemanlı yeni bir alan oluşturur
		//isimler[3] = "Sümeyye";

		//Console.WriteLine(isimler[3]);
		//Console.WriteLine(isimler[2]);
		//Console.WriteLine(isimler[1]);
		//Console.WriteLine(isimler[0]);

		//List kullanımı

		List<string> isimler2 = new List<string> { "Büşra", "Kübra", "Sena" };
		Console.WriteLine(isimler2[0]);
		Console.WriteLine(isimler2[1]);
		Console.WriteLine(isimler2[2]);
		isimler2.Add("Sümeyye");
		/**/isimler2.ForEach(x => Console.WriteLine(x)); //isimler 2 listesini yazdır
		isimler2.Add("Gülçin");
        Console.WriteLine(isimler2[3]);
		Console.WriteLine(isimler2[0]);
	}
}