using System;

class MainClass
{
    // ===================================== Задание 5.2.7

    static string ShowColor(string username, int userage)
    {
        Console.WriteLine("{0}, {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
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
    } // ---------------- заполнение любымых цветов   

    static int[] GetArrayFromConsole()                       // ------------------ ввод массива интов
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }     
    static int[] SortArray( int[] arrInt)                  // ------------------ сотрировка массива интов
    {

        int minPrev = 0;
        var l = arrInt.Length;               
        for (int i = 0; i < l; i++)
        {
            for (int k = i + 1; k < l; k++)
            {
                if (arrInt[i] > arrInt[k])
                {
                    minPrev = arrInt[i];
                    arrInt[i] = arrInt[k];
                    arrInt[k] = minPrev;
                }
            }
        }
        return arrInt;
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