using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.3.14
    // была проблема с служебными словами, которы хотел использовать как переменные. ...
    // row и column    Поэтому и сделал через цикл. ((

    {
        int[][] arr = new int[3][];
        arr[0] = new int[2] { 1, 2 };
        arr[1] = new int[3] { 1, 2, 3 };
        arr[2] = new int[5] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arr.GetUpperBound(0) +1; i++)
        {
            int[] row = arr[i];
            for (int j = 0; j < row.GetUpperBound(0) +1; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

        }

        //foreach (var row in arr)
        foreach(var arrRow in arr)
        {
            foreach (var arrColumn in arrRow)
            {
                Console.Write(arrColumn + " ");
            }
        }

        //Console.WriteLine();
        //Console.Write(arr[i] + " ");
        Console.ReadKey();
    }

}