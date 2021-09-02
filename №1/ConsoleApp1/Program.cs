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
            const double pi = 3.14;
            int result = 0;

            Console.Write("Enter the a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the b: ");
            int b = int.Parse(Console.ReadLine());

            //1.
            int count = 2;
            int sum = a + b;
            result = sum / count;
            Console.WriteLine("1. Avarage is {0}", result);

            //2.
            int x = -(b / a);
            Console.WriteLine("2. Result is {0}", x);

            //3.
            int step = 3;
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            result = Convert.ToInt32(Math.Pow(number, step));
            Console.WriteLine("3. {0} ^ {1} = {2}", number, step, result);

            //4. 
            Console.Write("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            result = Convert.ToInt32(pi * Math.Pow(radius, 2));
            Console.WriteLine("4. P = {0} * {1} ^ {2} = {3}", pi, radius, 2, result);

            //5.
            double dollar = 27.02;
            Console.Write("Enter amount of dollars: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("5. You have {0} grivnas", money * dollar);

            //6.
            double mile = 1.609;
            Console.Write("Enter amount miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("5. {0} miles is {1} km", miles, miles * mile);

            //7.
            Console.Write("Enter the year of your birthday: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter the month of your birthday: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter the day of your birthday: ");
            int day = int.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - year;
            if (DateTime.Now.Month < month ||
                (DateTime.Now.Month == month && DateTime.Now.Day < day))
            {
                age--;
            }

            Console.WriteLine("You are {0} years old", age);

            //8. 
            Console.Write("Enter the procent: ");
            double procent = double.Parse(Console.ReadLine());
            Console.Write("Enter the sum: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}% from {1} is {2}", procent, num, num * procent / 100);

            //9.
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Diametr is {0}", length / pi);

            //10.
            result = 0;

            for (int i = 0; i < 3; i++) {
                Console.Write("Denomination: ");
                int denomination = int.Parse(Console.ReadLine());
                Console.Write("Amount: ");
                int amount = int.Parse(Console.ReadLine());

                result += denomination * amount;
            }

            Console.WriteLine("Sum = {0}", result);
        }
    }
}
 