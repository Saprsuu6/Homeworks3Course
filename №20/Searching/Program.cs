using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Searching
{
    class Program
    {
        static void EmployerChoose(Logger log, SortedList<uint, FileInfo> correctFiles)
        {
            Console.Write("Удалить всё - 1");
            Console.Write("Удалить конкретный файл - 2");
            int choose = Convert.ToInt32(Console.ReadLine());
            int del;

            switch (choose)
            {
                case 1:
                    Console.Write("Вы точно хотите всё удалить? Да - 1, Нет - 2");
                    del = Convert.ToInt32(Console.ReadLine());

                    if (del == 1)
                    {
                        foreach (var item in correctFiles)
                        {
                            log.Trace(item.Value.FullName + "Был удалён.");
                            item.Value.Delete();
                        }
                    }
                    break;

                case 2:
                    Console.Write("Введите номер файла: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Вы точно хотите удалить? Да - 1, Нет - 2");
                    del = Convert.ToInt32(Console.ReadLine());

                    if (del == 1)
                    {
                        foreach (var item in correctFiles)
                        {
                            if (item.Key == number)
                            {
                                log.Trace(item.Value.FullName + "Был удалён.");
                                item.Value.Delete();
                            }
                        }
                    }

                    break;
            }
        }

        static void CheckFileForMask(FileInfo file, Regex regMask, ref uint counter, SortedList<uint, FileInfo> correctFiles)
        {
            if (regMask.IsMatch(file.Name))
            {
                correctFiles.Add(counter, file);

                Console.WriteLine("File #{0}: {1}\n\t Extention: {2}\n\t Creation time: {3}\n\t",
                    counter, file.Name, file.Extension, file.CreationTimeUtc);
            }
        }

        static void LocateDirictory(string path, Regex regMask, ref uint counter, SortedList<uint, FileInfo> correctFiles)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                string message = "Каталог с именем " + path + " небыл найден.";
                throw new ApplicationException(message);
            }
            else
            {
                FileInfo[] fis = null;
                DirectoryInfo[] dis = null;
                try
                {
                    dis = di.GetDirectories();

                    for (int i = 0; i < dis.Length; i++)
                    {
                        string newPath = path + dis[i].Name + "\\";
                        try
                        {
                            LocateDirictory(newPath, regMask, ref counter, correctFiles);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    fis = di.GetFiles();

                    foreach (FileInfo file in fis)
                    {
                        counter++;

                        try
                        {
                            CheckFileForMask(file, regMask, ref counter, correctFiles);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите букву диска: ");
            string path = Console.ReadLine();
            Console.Write("Введите маску для файлов: ");
            string mask = Console.ReadLine();

            path += ":\\";

            mask = mask.Replace(".", @"\.");
            mask = mask.Replace("?", ".");
            mask = mask.Replace("*", @".+");
            mask = "^" + mask + "$";

            Logger log = LogManager.GetCurrentClassLogger();
            SortedList<uint ,FileInfo> correctFiles = new SortedList<uint, FileInfo>();
            Regex regMask = new Regex(mask, RegexOptions.IgnoreCase);
            uint counter = 0;

            try
            {
                LocateDirictory(path, regMask, ref counter, correctFiles);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            correctFiles.RemoveAt(correctFiles.Count - 1); // я это сделал чтобы не удалять файл который мне необходим

            
        }
    }
}
