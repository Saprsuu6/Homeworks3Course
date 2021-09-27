using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    class Program
    {
        static void Main(string[] args)
        {
            Library E_N = new Library("English - Russian");
            E_N.AddWord("Ukrain", "Украина");

            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Choose wariant of translate: ");
            Console.WriteLine("1. English - Russian");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    string result = E_N.GetTranslate("Ukrain");
                    Console.WriteLine(result);
                    E_N.ChangeTranslateWord("Ukrain", "Russia");
                    E_N.RemoveWord("Ukrain");
                    break;
            }
        }
    }
}
