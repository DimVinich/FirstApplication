using System;

class MainClass
{
    static void Main(string[] args)
// ============================= модуль 5 Введение 1
    {
        ( string Name, string[] Dishes ) User;
        User.Dishes = new string[5];

        Console.WriteLine("Введите имя пользователя :");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите 5 любимых блюд пользователя");
        for (int i = 1; i < User.Dishes.Length; i++ )
        {
            Console.WriteLine("Блюдо {i} :", i + 1);
            User.Dishes[i] = Console.ReadLine();
        }

        Console.ReadKey();

        // Console.WriteLine(": {0}", name);
        // Console.WriteLine(" "); 
        //= Console.ReadLine();
        //= Convert.ToInt32(Console.ReadLine());
    }
}
