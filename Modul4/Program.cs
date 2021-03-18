using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.4.5
    
    {
        (string Name, string Type, double Age, int NameCount) Pet;

        Console.Write("Введите имя питомца: ");
        Pet.Name = Console.ReadLine();

        Console.Write("Ведите тип Вашего питомца (кошка, собака и т.д. ): ");
        Pet.Type = (Console.ReadLine());

        Console.Write("Ведите возвраст Вашего питомца: ");
        Pet.Age = Convert.ToDouble(Console.ReadLine());

        Pet.NameCount = Pet.Name.Length;

        Console.WriteLine("Имя Вашего питомца :{0}", Pet.Name);
        Console.WriteLine("Тип вашего питомца :{0}", Pet.Type );
        Console.WriteLine("Возраст вашего питомца :{0}", Pet.Age);


        //Console.WriteLine("Моё имя: {0}", name);
        //name = Console.ReadLine().ToString();
        Console.ReadKey();
    }

}