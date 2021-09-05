using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
        static void Draw(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void Fill(int[,] arr, int from, int to, Random rand)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(from, to);
                }
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];

            Fill(arr, 0, 100, rand);
            //Fill(arr, -100, 100, rand);
            Draw(arr);

            #region 1
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (j == i + 1)
            //        {
            //            Swap(ref arr[i, j], ref arr[i + 1, j - 1]);
            //        }
            //    }
            //}

            //Draw(arr);
            #endregion

            #region 2
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i == j && arr[i, j] != arr[i, j + (arr.GetLength(1) - (i + j + 1))])
            //        {
            //            Swap(ref arr[i, j], ref arr[i, j + (arr.GetLength(1) - (i + j + 1))]);
            //        }
            //    }
            //}

            //Draw(arr);
            #endregion

            #region 3
            //int max_x = 0, max_y = 0;
            //int min_x = 0, min_y = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (j != arr.GetLength(1) - 1 
            //            && arr[max_x, max_y] < arr[i, j + 1])
            //        {
            //            max_x = i;
            //            max_y = j + 1;
            //        }
            //        else if (j != arr.GetLength(1) - 1
            //            && arr[min_x, min_y] > arr[i, j + 1])
            //        {
            //            min_x = i;
            //            min_y = j + 1;
            //        }
            //    }
            //}

            //Console.WriteLine("Max is {0}, min is {1}", arr[max_x, max_y], arr[min_x, min_y]);

            //int sum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (max_x < min_x && (i == max_x && j >= max_y 
            //            || i > max_x && i < min_x || 
            //            i == min_x && j <= min_y))
            //        {
            //            sum += arr[i, j];
            //        }

            //        else if (max_x > min_x && (i == min_x && j >= min_y
            //            || i > min_x && i < max_x ||
            //            i == max_x && j <= max_y))
            //        {
            //            sum += arr[i, j];
            //        }

            //        else if (max_x == min_x && i == max_x &&
            //            j >= max_y && j <= min_y)
            //        {
            //            sum += arr[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("The sum is {0}", sum);
            #endregion

            #region 4
            //int max_x = 0, max_y = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (j != arr.GetLength(1) - 1
            //            && arr[max_x, max_y] < arr[i, j + 1])
            //        {
            //            max_x = i;
            //            max_y = j + 1;
            //        }
            //    }
            //}

            //Console.WriteLine("Max is {0}\n", arr[max_x, max_y]);

            //if (max_y != arr.GetLength(1))
            //{
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (j == max_y)
            //            {
            //                Swap(ref arr[i, j], ref arr[i, arr.GetLength(1) - 1]);
            //            }
            //        }
            //    }
            //}

            //Draw(arr);
            #endregion

            #region 5
            //int max_x = 0, max_y = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (j != arr.GetLength(1) - 1
            //            && arr[max_x, max_y] < arr[i, j + 1])
            //        {
            //            max_x = i;
            //            max_y = j + 1;
            //        }
            //    }
            //}

            //Console.WriteLine("Max is {0}\n", arr[max_x, max_y]);

            //if (max_x != arr.GetLength(0))
            //{
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (i == max_x)
            //            {
            //                Swap(ref arr[i, j], ref arr[arr.GetLength(0) - 1, j]);
            //            }
            //        }
            //    }
            //}

            //Draw(arr);
            #endregion

            #region 6 
            //int sum = 0;
            //int next_sum = 0;

            //for (int h = 0; h < arr.GetLength(0); h++)
            //{
            //    for (int i = 0; i < arr.GetLength(0) - 1; i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            sum += arr[j, i];

            //            if (i != arr.GetLength(1) - 1)
            //            {
            //                next_sum += arr[j, i + 1];
            //            }
            //        }

            //        if (sum < next_sum)
            //        {
            //            for (int l = 0; l < arr.GetLength(1); l++)
            //            {
            //                Swap(ref arr[l, i], ref arr[l, i + 1]);
            //            }
            //        }

            //        sum = 0;
            //        next_sum = 0;
            //    }
            //}

            //Draw(arr);

            //int temp = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        temp += arr[j, i];
            //    }

            //    Console.WriteLine("sum of {0} column's elements is {1}", i, temp);
            //    temp = 0;
            //}
            #endregion

            #region 7 
            //Console.WriteLine("right - 1, left - 2");
            //Console.Write("Choose the way: ");
            //int way = int.Parse(Console.ReadLine());
            //switch (way)
            //{
            //    case 1:
            //        for (int i = 0; i < arr.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < arr.GetLength(1); j++)
            //            {
            //                if (j != arr.GetLength(1) - 1)
            //                {
            //                    Swap(ref arr[i, 0], ref arr[i, j + 1]);
            //                }
            //            }
            //        }
            //        break;
            //    case 2:
            //        for (int i = 0; i < arr.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < arr.GetLength(1); j++)
            //            {
            //                if (j != arr.GetLength(1) - 1)
            //                {
            //                    Swap(ref arr[i, j], ref arr[i, j + 1]);
            //                }
            //            }
            //        }
            //        break;
            //}

            //Draw(arr);
            #endregion

            #region 8 
            //Console.WriteLine("up - 1, down - 2");
            //Console.Write("Choose the way: ");
            //int way = int.Parse(Console.ReadLine());
            //switch (way)
            //{
            //    case 1:
            //        for (int i = 0; i < arr.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < arr.GetLength(1); j++)
            //            {
            //                if (j != arr.GetLength(0) - 1)
            //                {
            //                    Swap(ref arr[j, i], ref arr[j + 1, i]);
            //                }
            //            }
            //        }
            //        break;
            //    case 2:
            //        for (int i = 0; i < arr.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < arr.GetLength(1); j++)
            //            {
            //                if (j != arr.GetLength(0) - 1)
            //                {
            //                    Swap(ref arr[0, i], ref arr[j + 1, i]);
            //                }
            //            }
            //        }
            //        break;
            //}

            //Draw(arr);
            #endregion

            #region 9 
            //int x = arr.GetLength(0) / 2 + 1;
            //int y = arr.GetLength(1) / 2 + 1;
            //int k = 0;

            //for (int i = 1; i < arr.Length + 1; i++)
            //{
            //    arr[x - 1, y - 1] = i;
            //    switch (k % 4)
            //    {
            //        case 0:
            //            y++;
            //            if ((x + 1) == y)
            //                k++;
            //            break;
            //        case 1:
            //            x--;
            //            if ((arr.GetLength(0) - x + 1) == y)
            //                k++;
            //            break;
            //        case 2:
            //            y--;
            //            if ((arr.GetLength(1) - x) == (arr.GetLength(1) - y))
            //                k++;
            //            break;
            //        case 3:
            //            x++;
            //            if (y == (arr.GetLength(0) - x + 1))
            //                k++;
            //            break;
            //    }
            //}

            //Draw(arr);
            #endregion

            #region 10
            //int[,] arr1 = new int[2, 3];
            //int[,] arr2 = new int[3, 2];
            //int[,] arr3 = new int[2, 2];

            //Fill(arr1, 0, 10, rand);
            //Fill(arr2, 0, 10, rand);

            //Draw(arr1);
            //Draw(arr2);

            //for (int a = 0; a < arr1.GetLength(0); a++)
            //{
            //    for (int b = 0; b < arr1.GetLength(0); b++)
            //    {
            //        for (int c = 0; c < arr1.GetLength(1); c++)
            //        {
            //            arr3[a, b] += arr1[a, c] * arr2[c, b];
            //        }
            //    }
            //}

            //Draw(arr3);
            #endregion
        }
    }
}
