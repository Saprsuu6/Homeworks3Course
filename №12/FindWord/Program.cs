using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder finder = new Finder();
            string str = "Я иду гуляю по Москве Я гуляю";

            try
            {
                finder.Find("гуляю", str);
                finder.Find("Я", str);
                finder.Find("иду", str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ShowWords show = new ShowWords(finder);
            show.Show();
        }
    }
}
