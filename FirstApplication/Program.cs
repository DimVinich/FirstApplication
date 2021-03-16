using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.Write("Enter your name: ");
		var name = Console.ReadLine().ToString();

		Console.Write("Enter your age: ");
		var age = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Your name is {0} and age is {1}", name, age);

		Console.Write("Enter your birthdate: ");
		var birthdate = Console.ReadLine();

		Console.WriteLine("Your birthdate is " + birthdate);

		Console.ReadKey();
		//Console.Write("");
		//Console.ReadLine();
		//test
	}
}