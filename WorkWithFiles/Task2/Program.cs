using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nFolder;
            
            // ================ ввод через запуск с аргументом
            // проверить, что аргумент вообче есть и задан
            //if (args.Length < 1)
            //{
            //    Console.WriteLine("Не заданна папка для подсчёта!");
            //        return;
            //}
            //nFolder = args[0]

            // =================== ввод через консоль
            Console.Write("Введите папку для подсчёта суммы : ");
            nFolder = Console.ReadLine();

            //nFolder = @"D:\WorkTemp\ToDel";

            if (!Directory.Exists(nFolder))
            {
                Console.WriteLine("Не существует папка для подсчёта!");
                // завершение работы
                return;
            }

            double sizeDir = 0;
            WorkWithFiles wf = new WorkWithFiles();
            sizeDir = wf.SizeDir(nFolder, ref sizeDir);

            Console.WriteLine($"Размер файлов и папок {sizeDir}");
            Console.ReadKey();
        }
    }

    public class WorkWithFiles
    {
        //  ========================== Суммирование файлов и папок
        public double SizeDir(string folder, ref double sizeDir)
        {

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                DirectoryInfo[] dirsInfo = dirInfo.GetDirectories();
                FileInfo[] filesInfo = dirInfo.GetFiles();

                foreach (FileInfo f in filesInfo)
                {
                    sizeDir = sizeDir + f.Length;
                }

                foreach (DirectoryInfo d in dirsInfo)
                {
                    SizeDir(d.FullName, ref sizeDir);
                }

                return sizeDir;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
                return 0;
            }
        }

    }
}
