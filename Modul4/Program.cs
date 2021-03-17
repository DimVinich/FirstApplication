using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.3.17
    
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 } , { -8, 8, 1, 1, 2, -3 } };
        int posNumber = 0;

        for (int i = 0; i < arr.GetUpperBound(0) +1; i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }


        //  =================== Сортировка
        int temp = 0;
        for (int k = 0; k <= arr.GetUpperBound(0); k++)
        {
            for (int i = 0; i <= arr.GetUpperBound(1); i++)
            {
                for (int j = i + 1; j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[k,i] > arr[k,j])
                    {
                        temp = arr[k, i];
                        arr[k, i] = arr[k, j];
                        arr[k, j] = temp;
                    }
                }

                Console.Write(arr[k, i] + " ");
            }

            Console.WriteLine();
        }


        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}