using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string arr = "!@ Я сижу и делаю домашку asd012345.";
            //string arr1 = "Я иду гуляю по Москве.";

            #region 1
            //Console.WriteLine("{0}", arr);
            //arr = arr.Replace(" ", "\t");
            //Console.WriteLine("{0}", arr);
            #endregion

            #region 2
            //int words = 0;
            //int digits = 0;
            //int otherSymbols = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= 'A' && arr[i] <= 'Z' ||
            //        arr[i] >= 'a' && arr[i] <= 'z' || 
            //        arr[i] >= 'А' && arr[i] <= 'Я' ||
            //        arr[i] >= 'а' && arr[i] <= 'я')
            //    {
            //        words++;
            //    }
            //    else if (arr[i] > '0' && arr[i] <= '9')
            //    {
            //        digits++;
            //    }
            //    else if (arr[i] >= 0 && arr[i] <= 47
            //        || arr[i] >= 54 && arr[i] <= 64
            //        || arr[i] >= 91 && arr[i] <= 96
            //        || arr[i] >= 123 && arr[i] <= 127)
            //    {
            //        otherSymbols++;
            //    }
            //}
            //Console.WriteLine("Amount of letters is {0}", words);
            //Console.WriteLine("Amount of digits is {0}", digits);
            //Console.WriteLine("Amount of digits is {0}", otherSymbols);
            #endregion

            #region 3
            //string[] arr2 = arr1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}", arr2.Length);
            #endregion

            #region 4
            //int counter = 0;
            //char[] letters = { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е',
            //'А', 'У', 'О', 'Ы', 'И', 'Э', 'Я', 'Ю', 'Ё', 'Е',
            //'A', 'E', 'I', 'O', 'U', 'Y',
            //'a', 'e', 'i', 'o', 'u', 'y'};

            //Console.Write("Enter the text: ");
            //string text = Console.ReadLine();

            //foreach (char it in text)
            //{
            //    foreach (char it2 in letters)
            //    {
            //        if (it == it2)
            //        {
            //            counter++;
            //        }
            //    }
            //}
            //Console.WriteLine(text);
            //Console.WriteLine("Count of vowel latters is {0}", counter);
            #endregion

            #region 5
            Console.Write("Enter the word: ");
            string text = Console.ReadLine();
            string text_reverse = new string(text.Reverse().ToArray());
            if (text.CompareTo(text_reverse) == 0)
            {
                Console.WriteLine("The word is palindrom");
            }
            else
            {
                Console.WriteLine("The word isn't palindrom");
            }
            #endregion
        }
    }
}
