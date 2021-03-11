using System;

class MainClass
{
	public static void Main(string[] args)
	{
		string MyName = "Computer";
		Console.WriteLine("Привет, человек");
		Console.WriteLine("Меня зовут {0}", MyName);
		Console.Write("А как тебя зовут? ");
		string YourName = Console.ReadLine();
		Console.Write("Рад встрече, {0} ", YourName);

		string str = Console.ReadLine();


		Console.ReadKey();
	}
}