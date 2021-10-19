using System;
using System.IO;
using System.Text.RegularExpressions;
using NLog;

namespace Logging
{
    class Program
    {
        static void Logging(string message, Logger log) => log.Trace(message);

        static void CheckFileForMask(FileInfo file, Regex regMask, Logger log)
        {
            if (regMask.IsMatch(file.Name))
            {
                Console.WriteLine("File " + file.Name);
                if (file.LastWriteTimeUtc.Year > 2015 && file.LastWriteTimeUtc.Year < 2025)
                    Logging(file.FullName, log);
            }
            else
            {
                string message = "Файл с именем " + file.FullName + " не соответсвет шаблону.";
                Logging(message, log);
                throw new ApplicationException(message);
            }
        }

        static void LocateDirictory(string path, Regex regMask, Logger log)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                string message = "Каталог с именем " + path + " небыл найден.";
                Logging(message, log);
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
                            LocateDirictory(newPath, regMask, log);
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
                        try
                        {
                            CheckFileForMask(file, regMask, log);
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
            Console.Write("Введите путь к каталогу: ");
            string path = Console.ReadLine();
            Console.Write("Введите маску для файлов: ");
            string mask = Console.ReadLine();

            if (path[path.Length - 1] != '\\')
                path += '\\';

            mask = mask.Replace(".", @"\.");
            mask = mask.Replace("?", ".");
            mask = mask.Replace("*", @".+");
            mask = "^" + mask + "$";

            Logger log = LogManager.GetCurrentClassLogger();
            Regex regMask = new Regex(mask, RegexOptions.IgnoreCase);

            try
            {
                LocateDirictory(path, regMask, log);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
