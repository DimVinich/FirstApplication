using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {

            Logger = new Logger();
            WriteTo writeTo = new WriteTo(Logger);

            NumberReader numberReader = new NumberReader();
            numberReader.NumReadEvent += GetNumber;

            double numberOne = 0.0, numberTwo = 0.0, summa = 0.0;

            try
            {
                numberReader.Read(ref numberOne);
            }
            catch (Exception)
            {
                writeTo.WriteError("Не то ввели. \n Повторите ввод");

                numberReader.Read(ref numberOne);
            }

            try
            {
                numberReader.Read(ref numberTwo);
            }
            catch (Exception)
            {
                writeTo.WriteError("Не то ввели. \n Повторите ввод");
                
                numberReader.Read(ref numberTwo);
            }

            BaseCalculator calculator = new BaseCalculator();
            summa = calculator.Summa(numberOne, numberTwo);

            writeTo.WriteResult("Сумма введённых чисел = " +summa);

            Console.ReadKey();
        }

        static double GetNumber(double number)
        {
            return number;
        }
    }

}
