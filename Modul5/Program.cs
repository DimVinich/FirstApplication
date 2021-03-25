using System;

class MainClass
{
    // ===================================== Задание 5.2.18

    static void ShowColors(string username, params string[] favcolors)      // ---------------- отображение любымых цветов  
    {
        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }

    static string ShowColor(string username, int userage)      // ---------------- заполнение любымых цветов  
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
    }

    static int[] GetArrayFromConsole(int num = 5)              // ------------------ ввод массива интов
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }     
    
    static int[] SortArray(int[] arrInt)                       // ------------------ сотрировка массива интов
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

    static void ShowArray(int[] arrInt, bool sort = false)
    {
        var temp = arrInt;
        if (sort)
        {
            temp = SortArray(arrInt);
        }

        for (int i = 0; i < arrInt.Length; i++)
        {
            Console.WriteLine(temp[i]);
        }
    }

    public static void Main(string[] args)
    {
        var array = GetArrayFromConsole(10);
        ShowArray(array, true);


        Console.ReadKey();

        // Console.WriteLine(": {0}", name);
        // Console.WriteLine(" "); 
        //= Console.ReadLine();
        //= Convert.ToInt32(Console.ReadLine());
    }
}