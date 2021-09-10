using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Testing()
        {
            Vector vector1 = new Vector(new int[] { 1, 2, 3, 4});

            Vector vector2 = vector1.CoppyVector();
            vector2.VectorToScalar(5);

            Show show1 = new Show(vector1);
            show1.ShowVector();
            Console.WriteLine();
            Show show2 = new Show(vector2);
            show2.ShowVector();

            Console.WriteLine();
            Console.WriteLine("The length of vector1 is {0}", vector1.Length());
            Console.WriteLine("The length of vector2 is {0}", vector2.Length());
            Console.WriteLine("The angle of vector1 is {0}", vector1.Angle());
            Console.WriteLine("The angle of vector2 is {0}", vector2.Angle());

            Console.WriteLine();
            vector1.VectorToScalar(10);
            vector2.VectorToScalar(10);
            show1.ShowVector();
            Console.WriteLine();
            show2.ShowVector();

            //Console.WriteLine();
            //vector1.VectorToUnscalar(2);
            //vector2.VectorToUnscalar(2);
            //show1.ShowVector();
            //Console.WriteLine();
            //show2.ShowVector();

            Vector sumVector = vector1.Sum(vector2);

            Show show3 = new Show(sumVector);
            Console.WriteLine();
            show3.ShowVector();

            //Vector differenceVector = vector1.Difference(vector2);

            //Show show4 = new Show(differenceVector);
            //Console.WriteLine();
            //show4.ShowVector();

            Vector ScalarElementVector = vector1.ElementScalar(vector2);

            Show show5 = new Show(ScalarElementVector);
            Console.WriteLine();
            show5.ShowVector();

            Console.WriteLine();
            Console.WriteLine("The scalar of vectors is {0}", vector1.VectorScalar(vector2));
            Console.WriteLine("The angle (cos) between vectors is {0}",
                vector1.AngleBetweenVectors(vector2));

            vector1.Equality(vector2);
        }

        static void Main(string[] args)
        {
            try
            {
                Testing();
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Operation was done");
            }
        }
    }
}
