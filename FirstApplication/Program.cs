using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //double result = 5.0 / 2.0;
        double result = 10 % 3;
        //Console.WriteLine("5 / 2 = {0}", result);
        Console.WriteLine("10 % 3 = {0}", result);

        double result2 = 5.0 % 2.0;
        Console.WriteLine("5 % 2 = {0}", result2);

        int counter = 10;
        Console.WriteLine("Value :  {0} Increment : {1}", counter, counter++);

    }
}