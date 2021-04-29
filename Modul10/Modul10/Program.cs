using System;
using System.Threading;

namespace Modul10
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();

            WriteTo writeTo = new WriteTo(Logger);
            writeTo.WriteResult("Фигня какаято получилась \n");
            writeTo.WriteError("Чего т пошло не так \n");

            Console.ReadKey();

        }
    }
    
    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }
    }

    public interface IWriteTo
    {
        void Write();
        void WriteResult(string result);
        void WriteError(string error);
    }

    public class WriteTo : IWriteTo
    {
        ILogger Logger { get; }
        public WriteTo(ILogger logger)
        {
            Logger = logger;
        }
        public void Write()
        {
            Logger.Event("Событие куда то записалось");
            Thread.Sleep(3000);
            Logger.Event("Куда то записалоьс хвост");
        }
        public void WriteResult(string result)
        {
            Logger.Event(result);
        }

        public void WriteError(string error)
        {
            Logger.Error(error);
        }

    }

}
