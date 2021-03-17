using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.3.12

    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int minPrev;

        var l = arr.Length;
        for (int i = 0; i < l; i++) 
        {
            for (int k = i + 1; k < l; k++)
            {
                if (arr[i] > arr[k]  )
                {
                    minPrev = arr[i];
                    arr[i] = arr[k];
                    arr[k] = minPrev;
                }
            }
                        
            Console.Write(arr[i] + " ");
        }

        //Console.WriteLine();
        Console.ReadKey();
    }

}