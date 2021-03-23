using System;

class MainClass
{
    // ===================================== Задание 5.2.3

    // ---------------- заполнение любымых цветов   
    static string ShowColor(string username)
    {
        Console.WriteLine("{0}, Напишите свой любимый цвет на английском с маленькой буквы", username);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }

        return color;
    }

    // ------------------ ввод массива интов с сотритовкой
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        int minPrev = 0;
        var l = result.Length;               // Отсортировали массив
        for (int i = 0; i < l; i++)
        {
            for (int k = i + 1; k < l; k++)
            {
                if (result[i] > result[k])
                {
                    minPrev = result[i];
                    result[i] = result[k];
                    result[k] = minPrev;
                }
            }
        }
        return result;
    }


    public static void Main(string[] args)
    {
        (string name, int age) anketa;

        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        var favcolors = new string[3];
        
        for (int i = 0; i < favcolors.Length; i++)
        {
             favcolors[i]= ShowColor(anketa.name);
        }

        Console.WriteLine("Ваши любимые цвета ");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }

        Console.ReadKey();

        // Console.WriteLine(": {0}", name);
        // Console.WriteLine(" "); 
        //= Console.ReadLine();
        //= Convert.ToInt32(Console.ReadLine());
    }
}