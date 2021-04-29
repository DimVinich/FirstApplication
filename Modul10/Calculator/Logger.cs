using System;

namespace Calculator
{
    public class Logger : ILogger
        {
            public void Error(string message)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
        }
        public void Event(string message)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
            }
        }

}
