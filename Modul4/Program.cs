using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.3.13

    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int sum = 0;

        foreach (var item in arr)
        {
            sum += item;
        }

        Console.WriteLine("Сумма массива = " + sum);
        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}