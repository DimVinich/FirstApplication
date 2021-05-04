using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Serializer
    {
        static void Main(string[] args)
        {
            // Проверить, что файл есть.
            string nFile = @"D:\WorkTemp\Students.dat";
            if (!File.Exists(nFile))
            {
                Console.WriteLine("Файл задан не верно!");
                return;
            }

            //  Созадать папку, запомнить её путь, проверить на наличие уже
            string nDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Students";
            if (!Directory.Exists(nDir))
            {
                Directory.CreateDirectory(nDir);
            }

            // Считать массив сущьностей   И в трай кеч завернуть. Не понятно ток зачем
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream(nFile, FileMode.OpenOrCreate))
            {
                Student[] newStudent = (Student[])formatter.Deserialize(fs);
                foreach(Student s in newStudent)
                {
                    // Распихиваем студентов по папкам
                    string nFileGroup = nDir+ "\\" + s.Group + ".txt";
                    using (StreamWriter sw = new StreamWriter(nFileGroup, true))
                    {
                        sw.WriteLine(s.Name + ", " + s.DateOfBirth);
                    }
                }
            }

            Console.WriteLine("Обработка завершена");
            Console.ReadKey();
        }
    }
}
