using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NLog;

namespace ParsingHTML
{
    class Program
    {
        static void Saving(FileInfo file, Logger logger, string content)
        {
            Console.WriteLine("Сохранить в этом же файле - 1\nСохранить коптю рядом - 2");
            Console.Write("Выберите способ: ");
            int chose = Convert.ToInt32(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    using (StreamWriter writer = new StreamWriter(file.FullName, false))
                    {
                        writer.Write(content);
                        logger.Trace("Html was writed in " + file.FullName);
                    }

                    break;

                case 2:
                    using (StreamWriter writer = new StreamWriter(file.DirectoryName + @"\ProjectCoppy.html", false))
                    {
                        writer.Write(content);
                        logger.Trace("Html was writed in " + file.DirectoryName + @"\ProjectCoppy.html");
                    }

                    break;
            }
        }

        static void ParsingFile(FileInfo file, Regex regMaskFile, Regex regMaskText)
        {
            string content;
            MatchCollection collection;
            Logger logger = LogManager.GetCurrentClassLogger();

            using (StreamReader reader = new StreamReader(file.FullName, Encoding.Default))
            {
                content = reader.ReadToEnd();
                collection = regMaskText.Matches(content);
                if (collection.Count < 1)
                {
                    logger.Trace("Teg was not found in file." + file.FullName);
                    throw new ApplicationException("Teg was not found in file." + file.FullName);
                }
            }

            foreach (Match item in collection)
            {
                logger.Trace("Teg " + item.ToString() + " was delete in file " + file.FullName);
                content = content.Replace(item.ToString(), "");
            }

            Saving(file, logger, content);
        }

        static void CheckFileForMask(FileInfo file, Regex regMaskFile, Regex regMaskText)
        {
            if (regMaskFile.IsMatch(file.Name))
                ParsingFile(file, regMaskFile, regMaskText);
        }

        static void LocateDirictory(string path, Regex regMaskFile, Regex regMaskText)
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
                            LocateDirictory(newPath, regMaskFile, regMaskText);
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
                            CheckFileForMask(file, regMaskFile, regMaskText);
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
            Console.Write("Введите путь: ");
            string path = Console.ReadLine();
            Console.Write("Введите название файла: ");
            string name = Console.ReadLine();
            Console.Write("Введите название тега: ");
            string teg = Console.ReadLine();

            Regex regMaskFile = new Regex(name + @"\.html|xhtml", RegexOptions.IgnoreCase);
            Regex regMaskText = new Regex("<.?" + teg.ToLower() + ">", RegexOptions.IgnoreCase);

            LocateDirictory(path, regMaskFile, regMaskText);
        }
    }
}
