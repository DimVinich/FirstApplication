using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BaseCalculator : ICalculator
    {
        public double Summa(double numberOne, double numberTwo)
        {
            return (numberOne + numberTwo);
        }
    }
}
