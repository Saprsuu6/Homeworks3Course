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
            ////1.
            //for (int indexer = 0; indexer < 256; indexer++)
            //{
            //    Console.Write("{0}", Convert.ToChar(indexer));
            //}
            //Console.Write("\n");

            ////2.
            //Console.Write("Enter amount of dots: ");
            //int amount = int.Parse(Console.ReadLine());
            //for (int indexer = 0; indexer < amount; indexer++)
            //{
            //    Console.Write("*");
            //}
            //Console.Write("\n");

            ////3.
            //for (int indexer = 1; indexer <= 20; indexer++)
            //{
            //    if (indexer % 2 == 0)
            //    {
            //        Console.Write("{0} ", indexer);
            //    }
            //}
            //Console.Write("\n");

            ////4.
            //int counter = 0;
            //for (int indexer = 0; indexer < 50; indexer++)
            //{
            //    counter += indexer;
            //}
            //Console.Write("{0}\n", counter);

            ////5.
            //int sumOfEven = 0;
            //int sumOfOdd = 1;
            //for (int indexer = 1; indexer < 10; indexer++)
            //{
            //    if (indexer % 2 == 0)
            //    {
            //        sumOfEven += indexer;
            //    }
            //    else if (indexer % 2 != 0)
            //    {
            //        sumOfOdd *= indexer;
            //    }
            //}
            //Console.Write("Sum of even {0}, Sum of odd {1}\n",
            //    sumOfEven, sumOfOdd);

            ////6.
            //for (int indexer = 0; indexer < 100; indexer++)
            //{
            //    if (indexer % 3 == 0)
            //    {
            //        Console.Write("{0} ", indexer);
            //    }
            //}
            //Console.Write("\n");

            ////7.
            //int temp = 1;
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Factorial of the 0 is 0: ");
            //}
            //else
            //{
            //    for (int indexer = 1; indexer <= number; indexer++)
            //    {
            //        temp *= indexer;
            //    }
            //    Console.WriteLine("Factorial of the {0} is {1}: ", number, temp);
            //}

            ////8.
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Enter the pow: ");
            //int pow = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pow of {0} is {1}", number,
            //    Math.Pow(number, pow));

            ////9.
            //int counter = 0;
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //int temp = number;
            //double sum = 0;
            //string str = Convert.ToString(temp);
            //while (temp != 0)
            //{
            //    sum += Char.GetNumericValue(str, counter);

            //    if (temp != 0)
            //    {
            //        counter++;
            //    }

            //    temp /= 10;
            //}
            //Console.WriteLine("The rande of the number {0} is {1} and sum of numbers is {2}",
            //    number, counter, sum);

            ////10.
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //int temp = number;
            //string str = Convert.ToString(temp);
            //int length = str.Length;


            //for (int i = length; i > 0; i--)
            //{
            //    Console.Write(str[i - 1]);
            //}
            //Console.Write("\n");

            ////11.
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}
            //Console.Write("\n");

            ////12.
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0 && (i != 1 && i != number))
            //    {
            //        Console.WriteLine("The number isn't simple");
            //        break;
            //    }
            //    else if (i == number)
            //    {
            //        Console.WriteLine("The number is simple");
            //    }
            //}

            ////13.
            //int counter = 0;
            //Console.Write("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //int temp = number;
            //string str = Convert.ToString(temp);
            //int length = str.Length;

            //for (int i = 0; i < length - 1; i++)
            //{
            //    if (str[i] != str[i + 1])
            //    {
            //        Console.WriteLine("The same simbols not exist");
            //        break;
            //    }
            //    else if (i == length - 2)
            //    {
            //        Console.WriteLine("The same simbols exist");
            //    }
            //}

            //14.
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            string str = Convert.ToString(temp);
            int length = str.Length;

            for (int i = 0; i < length - 1; i++)
            {
                if (str[i] > str[i + 1])
                {
                    Console.WriteLine("The symbols are decreases");
                    break;
                }
                else if (i == length - 2)
                {
                    Console.WriteLine("The number aren't decreases");
                }
            }
        }
    }
}
