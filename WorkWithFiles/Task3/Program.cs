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
            //    Console.WriteLine("Не заданна папка для обработки!");
            //        return;
            //}
            //nFolder = args[0]

            // =================== ввод через консоль
            Console.Write("Введите папку для обработки : ");
            nFolder = Console.ReadLine();

            //nFolder = @"D:\WorkTemp\ToDel";

            if (!Directory.Exists(nFolder))
            {
                Console.WriteLine("Не существует папки для обработки!");
                // завершение работы
                return;
            }

            double sizeDir = 0;
            WorkWithFiles wf = new WorkWithFiles();

            //  Размер папки До зачистки
            sizeDir = wf.SizeDir(nFolder, ref sizeDir);
            Console.WriteLine($"Исходный размер папки: {sizeDir}  байт");

            // Зачистка с подсчётом зачищенного
            sizeDir = 0;
            int fileCount = 0;
            sizeDir = wf.DelOlderInf30WithCount(nFolder, ref sizeDir, ref fileCount);
            Console.WriteLine($"Удалено Файлов: {fileCount}");
            Console.WriteLine($"Освобождено: {sizeDir} байт");

            //  Размер папки после зачистки
            if (!Directory.Exists(nFolder))
            {
                Console.WriteLine("Папка полностью удалена. Текущий размер папки : 0");
                // завершение работы
                return;
            }

            sizeDir = 0;
            sizeDir = wf.SizeDir(nFolder, ref sizeDir);
            Console.WriteLine($"Текущий размер папки: {sizeDir} байт");

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

        // ========================= удаление файлов свыше 30-ти дней с подсчётом удалённых файлов
        public double DelOlderInf30WithCount(string folder, ref double sizeDelFiles, ref int fileCount)
        {
            double older = 30;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                DirectoryInfo[] dirsInfo = dirInfo.GetDirectories();
                FileInfo[] filesInfo = dirInfo.GetFiles();

                foreach (FileInfo f in filesInfo)
                {
                    if ((DateTime.Now - File.GetLastWriteTime(f.FullName)).TotalMinutes > older)
                    {
                        fileCount++;
                        sizeDelFiles += f.Length;
                        f.Delete();
                    }
                }

                foreach (DirectoryInfo d in dirsInfo)
                {
                    if ((DateTime.Now - Directory.GetLastWriteTime(d.FullName)).TotalMinutes > older)
                        DelOlderInf30WithCount(d.FullName, ref sizeDelFiles, ref fileCount);
                }

                if (dirInfo.GetDirectories().Length == 0 && dirInfo.GetFiles().Length == 0)
                {
                    dirInfo.Delete();
                }

                return sizeDelFiles;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
                return 0;
            }
        }

    }
}
