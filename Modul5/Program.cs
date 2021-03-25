using System;

namespace UserAnketa
{
    class Program
    {
        // ================================================= Задание 5.6

        static void Main(string[] args)
        {
            (string name, string surname, int age, int fHavePet, int CountPet, string[] NamePet, int CountColor, string[] NameColor) anketa;
            string YesPet;
            string sEnter;
            int iEnter;
            bool fOkChek;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            anketa.surname = Console.ReadLine();

            do
            {
                Console.Write("Введите возраст цифрами: ");
                sEnter = Console.ReadLine();

            } while (ChekNumber(sEnter, out iEnter) == false);

            anketa.age = iEnter;

            anketa.fHavePet = 0;

            do
            {
                Console.Write("Есть ли у вас питомцы?");
                YesPet = Console.ReadLine();

                if (YesPet.ToLower() == "yes" || YesPet.ToLower() == "да")
                {
                    anketa.fHavePet = 1;
                    fOkChek = true;
                }
                else
                {
                    if (YesPet.ToLower() == "no" || YesPet.ToLower() == "нет")
                    {
                        anketa.fHavePet = 0;
                        fOkChek = true;
                    }
                    else
                    {
                        fOkChek = false;
                    }
                }

            } while (fOkChek == false);

            string[] NameNull = new string[1];

            NameNull[0] = "";

            anketa.NamePet = NameNull;
            anketa.CountPet = 0;

            if (anketa.fHavePet == 1)
            {
                do
                {
                    Console.Write("Введите количество ваших питомцев: ");
                    sEnter = Console.ReadLine();
                } while (ChekNumber(sEnter, out iEnter) == false);

                anketa.CountPet = iEnter;
                anketa.NamePet = WhatNamePet(anketa.CountPet);
            }

            do
            {
                Console.Write("Сколько у вас любимых цветов? ");
                sEnter = Console.ReadLine();
            } while (ChekNumber(sEnter, out iEnter) == false);

            anketa.CountColor = iEnter;

            anketa.NameColor = NameNull;

            anketa.NameColor = WhatFavoritColor(anketa.CountColor);


            PrintDate((anketa));

            Console.ReadKey();
        }

        static bool ChekNumber(string Snumber, out int Inumber)
        {
            if (Int32.TryParse(Snumber, out int intNumber))
            {
                if (intNumber > 0)
                {
                    Inumber = intNumber;
                    return true;
                }
            }
            {
                Inumber = 0;
                return false;
            }
        }

        static string[] WhatNamePet(int kol)
        {
            string[] NamePet = new string[kol];

            for (int i = 0; i < NamePet.Length; i++)
            {
                Console.WriteLine("Введите кличку питомца {0} : ", i + 1);
                NamePet[i] = Console.ReadLine();
            }

            return NamePet;
        }

        static string[] WhatFavoritColor(int kol)
        {
            string[] NameColor = new string[kol];

            for (int i = 0; i < NameColor.Length; i++)
            {
                Console.WriteLine("Введите цвет {0} : ", i + 1);
                NameColor[i] = Console.ReadLine();
            }

            return NameColor;
        }

        static void PrintDate((string name, string surname, int age, int fHavePet, int CountPet, string[] NamePet, int CountColor, string[] NameColor) Fullanketa)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.WriteLine(" -- Анкета --");
            Console.WriteLine("Ваше имя: " + Fullanketa.name);
            Console.WriteLine("Ваша Фамилия: " + Fullanketa.surname);
            Console.WriteLine("Ваш возраст: " + Fullanketa.age);
            Console.WriteLine("Наличие питомцев: " + (Fullanketa.fHavePet == 1 ? "Есть" : "Нет"));
            if (Fullanketa.fHavePet == 1)
            {
                Console.WriteLine("\tУ вас {0} питомцев ", Fullanketa.CountPet);
                Console.WriteLine("\tКлички ваших питомцев: ");
                foreach (var Name in Fullanketa.NamePet)
                {
                    Console.WriteLine("\t\t" + Name);
                }
            }
            Console.WriteLine("У Вас {0} любимых цветов: ", Fullanketa.CountColor);
            foreach (var NColor in Fullanketa.NameColor)
            {
                Console.WriteLine("\t" + NColor);
            }
            Console.ResetColor();
        }
    }
}
