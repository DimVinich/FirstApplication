using System;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    public interface IMessenger<T>
    {
        T DeviceInfo();
    }
    public class Phone { }
    public class Computer { }

    public class Viber : IMessenger<Phone>
    {
        public Phone DeviceInfo()
        {
            return null;
        }
    }

}
