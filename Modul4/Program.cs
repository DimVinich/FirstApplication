using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.4.2
    
    {
        var anketa = (name: "", age: 0, birthdate: "");

        Console.Write("Enter your name: ");
        anketa.name = Console.ReadLine().ToString();

        Console.Write("Enter your age: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name is {0} and age is {1}", anketa.name, anketa.age);

        Console.Write("Enter your birthdate: ");
        anketa.birthdate = Console.ReadLine();

        Console.WriteLine("Your birthdate is " + anketa.birthdate);

        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}