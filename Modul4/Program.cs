using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.3.16
    
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 } , { -8, 8, 1, 1, 2, -3 } };
        int posNumber = 0;

        foreach (var arrItem in arr)
        {
            posNumber = arrItem > 0 ? ++posNumber : posNumber;
        }
        Console.WriteLine("кол-во положительных чисел " + posNumber);


        posNumber = 0;

        for (int i = 0; i < arr.GetUpperBound(0) +1; i++)
        {
            for(int j = 0; j < arr.GetUpperBound(1) +1; j++)
            posNumber = arr[i,j] > 0 ? ++posNumber : posNumber;
        }
        Console.WriteLine("кол-во положитеьных чисел "+posNumber);

        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}