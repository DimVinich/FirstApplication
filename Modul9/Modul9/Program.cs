using System;

namespace Modul9
{
    class Program
    {
        static void Main(string[] args)
        {

            Exception[] except = new Exception[] {
                new RankException(),
                new DivideByZeroException(),
                new ArgumentOutOfRangeException(),
                new OverflowException(),
                new MyException("MyException")};

            for (int i = 0; i < except.Length; i++)
            {
                
                try
                {
                    throw except[i];
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Исключение \n"+ ex.Message);
                }
                catch (RankException ex)
                {
                    Console.WriteLine("Исключение \n" + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Исключение \n" + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Исключение \n" + ex.Message);
                }
                catch (MyException ex)
                {
                    Console.WriteLine("Исключение \n" + ex.Message);
                }

                finally
                {
                    Console.ReadKey();
                }
            }


            Console.ReadKey();
        }          // Хвост метода
    }           // Хвост класса
    public class MyException : Exception    // =========== Собственное исключение
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }

}
