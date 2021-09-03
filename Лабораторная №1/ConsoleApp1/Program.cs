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
            Random rand = new Random();
            int[,] arr = new int[5, 5];

            #region 1
            //int mainSum = 0;
            //int notMainSum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rand.Next(0, 20);

            //        if (i == j)
            //        {
            //            mainSum += arr[i, j]; 
            //        }
            //        if (j + 1 == arr.GetLength(1) - i)
            //        {
            //            notMainSum += arr[i, j];
            //        }

            //        Console.Write("{0,4}", arr[i, j]);
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("The main sum is {0}, not main sum is {1}",
            //    mainSum, notMainSum);
            #endregion

            #region 2
            //int counter = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rand.Next(-5, 5);

            //        if (arr[i, j] >= 0)
            //        {
            //            counter++;
            //        }

            //        Console.Write("{0,4}", arr[i, j]);
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("The count is {0}", counter);
            #endregion

            #region 3
            //int sum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rand.Next(0, 20);

            //        sum += arr[i, j];

            //        Console.Write("{0,4}", arr[i, j]);
            //    }

            //    Console.WriteLine(" | The sum is {0}", sum);
            //    sum = 0;
            //}
            #endregion

            #region 4
            //int sum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[j, i] = rand.Next(0, 20);

            //        sum += arr[j, i];

            //        Console.Write("{0,4}", arr[i, j]);
            //    }

            //    Console.WriteLine(" | The sum is {0}", sum);
            //    sum = 0;
            //}
            #endregion

            #region 5
            //bool temp = false;
            //int sum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rand.Next(-10, 40);

            //        if (arr[i, j] >= 0 && !temp)
            //        { 
            //            sum += arr[i, j];
            //        }
            //        else if (arr[i, j] < 0 && !temp)
            //        {
            //            temp = true;
            //        }

            //        Console.Write("{0,4}", arr[i, j]);
            //    }

            //    if (!temp)
            //    {
            //        Console.WriteLine(" | The sum is {0}", sum);
            //        sum = 0;
            //    }
            //    else 
            //        temp = false;
            //}
            #endregion
        }
    }
}
