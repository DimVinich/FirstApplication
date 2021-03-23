using System;

class MainClass
{
    // ===================================== Задание 5.1.7

    // ---------------- заполнение любымых цветов   
    static string ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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

    // ------------------ Заполнение массива интов
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }


    public static void Main(string[] args)
    {
        var arrInput = new int[5];
        int minPrev;

        arrInput = GetArrayFromConsole();   // Заполнили массив

        //      А можно было и так
        // var int[] array = GetArrayFromConsole();

        var l = arrInput.Length;               // Отсортировали массив
        for (int i = 0; i < l; i++)
        {
            for (int k = i + 1; k < l; k++)
            {
                if (arrInput[i] > arrInput[k])
                {
                    minPrev = arrInput[i];
                    arrInput[i] = arrInput[k];
                    arrInput[k] = minPrev;
                }
            }

            Console.Write(arrInput[i] + " ");
        }

         Console.ReadKey();

        // Console.WriteLine(": {0}", name);
        // Console.WriteLine(" "); 
        //= Console.ReadLine();
        //= Convert.ToInt32(Console.ReadLine());
    }
}