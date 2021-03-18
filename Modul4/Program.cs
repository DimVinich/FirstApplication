using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.4.3
    
    {
        var (name, age) = ("Dimon", 99);

        Console.WriteLine("Моё имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine().ToString();

        Console.Write("Ведите возраст с цифрами: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя :{0}", name);
        Console.WriteLine("Ваш возраст :{0}", age);

        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}