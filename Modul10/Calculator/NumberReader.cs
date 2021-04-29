using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberReader
    {
        public delegate double NumReadDelegate(double number);
        public event NumReadDelegate NumReadEvent;

        public void Read(ref double number)
        {
            Console.WriteLine($"Введите число для сложения :");
            number = Convert.ToDouble(Console.ReadLine());
            NumRead(number);
        }

        protected virtual void NumRead(double number)
        {
            NumReadEvent?.Invoke(number);
        }
    }
}
