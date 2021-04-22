using System;
using System.Collections.Generic;

namespace Modul91
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyList> listSotr = new List<MyList>();
            listSotr.Add(new MyList() { LastName = "Иванов" });
            listSotr.Add(new MyList() { LastName = "Петров" });
            listSotr.Add(new MyList() { LastName = "Сидоров" });
            listSotr.Add(new MyList() { LastName = "Васичкин" });
            listSotr.Add(new MyList() { LastName = "Пупкин" });



            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEventList += ShowList;

            while (true)
            {
                try
                {
                    numberReader.ReadWithSort(ref listSotr);
                }
                catch (MyException ex)
                {
                    Console.WriteLine("Введенно не корректное занчение \n" + ex.Message);
                }
            }

            Console.ReadKey();
        }

        static void ShowList(int number, ref List<MyList> listSort)
        {
            MyList.sotrMyList(listSort, number);
        }
    }


    class NumberReader
    {
        public delegate void ListSortDelegate(int number, ref List<MyList> listSort);
        public event ListSortDelegate NumberEnteredEventList;

        public void ReadWithSort(ref List<MyList> listSort)
        {
            Console.WriteLine();
            Console.WriteLine("Для сортировки списка по А-Я введите 1. Для обратной сортировки введите 2. ");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new MyException("Нужно ввести либо 1 либо 2");  // поменять на свое исключение
            NumberEnteredList(number, ref listSort);
        }

        protected virtual void NumberEnteredList(int number, ref List<MyList> listSort)
        {
            NumberEnteredEventList?.Invoke(number, ref listSort);
        }

    }

    public class MyException : Exception    // =========== Собственное исключение
    {
        public MyException()
        { }

        public MyException(string message) : base(message) { }
    }


    public class MyList
    {
        public string LastName { get; set; }
        //        public string Name { get; set; }

        public static void sotrMyList(List<MyList> listSotr, int typeSotr)
        {
            if (typeSotr == 1)
            {

                listSotr.Sort(delegate (MyList x, MyList y)
                {
                    if (x.LastName == null && y.LastName == null) return 0;
                    else if (x.LastName == null) return -1;
                    else if (y.LastName == null) return 1;
                    else return x.LastName.CompareTo(y.LastName);
                });
            }
            else
            {
                listSotr.Sort(delegate (MyList x, MyList y)
                {
                    if (x.LastName == null && y.LastName == null) return 0;
                    else if (x.LastName == null) return 1;
                    else if (y.LastName == null) return -1;
                    else return y.LastName.CompareTo(x.LastName);
                });
            }

            foreach (MyList ls in listSotr)
            {
                Console.WriteLine(" {0} ", ls.LastName);
            }
        }
    }
}
