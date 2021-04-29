using System;

namespace CheckInput
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumReadEvent += ShowNum;
            

            try
            {
                numberReader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не то ввели \n ещё раз");
            //      реализацию логера воткнуть
                numberReader.Read();
            }
            
        }

        static double ShowNum(double number)
        {
            //Console.WriteLine($"Введено {number}");
            //break;
            return number;
        }
    }

    class NumberReader
    {
        public delegate double NumReadDelegate(double number);
        public event NumReadDelegate NumReadEvent;

        public void Read()
        {
            Console.WriteLine($"Введите число для сложения :");
            double number = Convert.ToDouble(Console.ReadLine());
            NumRead(number);
        }

        protected virtual void NumRead( double number)
        {
            NumReadEvent?.Invoke(number);
        }
    }
}
