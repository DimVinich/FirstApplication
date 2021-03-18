using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.4.2 часть 2
    //              Исходный код взят с финального здания модуля 3
    
    {
        //var anketa = (name: "", age: 0, birthdate: "");
        // Более правильное задание кортеджа
        //(string name, int age, string birthdate) anketa;

        // ещё одни вариант декларирования кортеджа
        var (name, age, birthdate) = ("Dimon", 99, "32.13.2222");

        //Console.Write("Enter your name: ");
        //anketa.name = Console.ReadLine().ToString();

        //Console.Write("Enter your age: ");
        //anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name is {0} and age is {1}", name, age);

        //Console.Write("Enter your birthdate: ");
        //anketa.birthdate = Console.ReadLine();

        Console.WriteLine("Your birthdate is " + birthdate);

        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}