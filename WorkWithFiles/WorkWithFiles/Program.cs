using System;
using System.IO;

namespace WorkWithFiles
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
            //    Console.WriteLine("Не заданна папка для удаления!");
            //        return;
            //}
            //nFolder = args[0]

            // =================== ввод через консоль
            Console.Write("Введите папку для подсчёта суммы : ");
            nFolder = Console.ReadLine();

            //nFolder = @"D:\WorkTemp\ToDel";

            if (!Directory.Exists(nFolder))
            {
                Console.WriteLine("Не заданна папка для удаления!");
                // завершение работы
                return;
            }

            WorkWithFiles wf = new WorkWithFiles();
            wf.DelOlderInf30(nFolder);

            Console.WriteLine("Уделение завершено");
            Console.ReadKey();

        }

    }

    public class WorkWithFiles
    {
        public void DelOlderInf30(string folder)
        {
            double older = 30;
            
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                DirectoryInfo[] dirsInfo = dirInfo.GetDirectories();
                FileInfo[] filesInfo = dirInfo.GetFiles();

                foreach (FileInfo f in filesInfo)
                {
                    if((DateTime.Now - File.GetLastWriteTime(f.FullName)).TotalMinutes > older)
                    {
                        f.Delete();
                    }
                }

                foreach (DirectoryInfo d in dirsInfo)
                {
                    if ((DateTime.Now - Directory.GetLastWriteTime(d.FullName)).TotalMinutes > older)
                        DelOlderInf30(d.FullName);
                }

                if (dirInfo.GetDirectories().Length == 0 && dirInfo.GetFiles().Length == 0)
                {
                    dirInfo.Delete();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }


    }

}
