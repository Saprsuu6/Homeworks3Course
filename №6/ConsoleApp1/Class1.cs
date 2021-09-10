using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Show
    {
        private Vector vector;

        public Show(Vector vector) => this.vector = vector;
        public void ShowVector()
        {
            Console.WriteLine("X = {0}", vector.X);
            Console.WriteLine("X = {0}", vector.Y);
            Console.WriteLine("X = {0}", vector.Z);
        }
    }
    class Vector
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;

        public Vector() { }

        public Vector(int x)
        {
            if (x <= 0)
                throw new ApplicationException("The params must be gratter the 0");

            this.x = x;
        }
        public Vector(int x, int y) : this(x)
        {
            if (y <= 0)
                throw new ApplicationException("The params must be gratter the 0");

            this.y = y;
        }
        public Vector(int x, int y, int z) : this(x, y)
        {
            if (z <= 0)
                throw new ApplicationException("The params must be gratter the 0");

            this.z = z;
        }
        public Vector(params int[] values)
        {
            if (values.Length > 3)
                throw new CountParams();

            if (values.Length == 1)
            {
                x = values[0];
            }
            else if (values.Length == 2)
            {
                x = values[0];
                y = values[1];
            }
            else
            {
                x = values[0];
                y = values[1];
                z = values[2];
            }
        }

        public int X
        { 
            set 
            {
                if(value <= 0)
                    throw new ApplicationException("The params must be gratter the 0");

                x = value;
            }
            get {
                return x;
            }
        }
        public int Y 
        {
            set
            {
                if (value <= 0)
                    throw new ApplicationException("The params must be gratter the 0");

                y = value;
            }
            get 
            {
                return y;
            }
        }
        public int Z 
        { 
            set 
            {
                if (value <= 0)
                    throw new ApplicationException("The params must be gratter the 0");

                z = value;
            } 
            get 
            { 
                return z;
            }
        }

        public Vector CoppyVector()
        {
            return new Vector(X, Y, Z);
        }
        public double Length()
        {
            return Math.Sqrt(x ^ 2 + y ^ 2 + z ^ 2);
        }
        public double Angle()
        {
            return Math.Atan2(x, y);
        }
        public void VectorToScalar(int scalar)
        {
            x *= scalar;
            y *= scalar;
            z *= scalar;
        }
        public void VectorToUnscalar(int scalar)
        {
            x /= scalar;
            y /= scalar;
            z /= scalar;
        }
        public Vector Sum(Vector vector)
        {
            return new Vector(X + vector.X, Y + vector.Y, Z + vector.Z); ;
        }
        public Vector Difference(Vector vector)
        {
            return new Vector(X - vector.X, Y - vector.Y, Z - vector.Z);
        }
        public Vector ElementScalar(Vector vector)
        {
            return new Vector(X * vector.X, Y * vector.Y, Z * vector.Z);
        }
        public int VectorScalar(Vector vector)
        {
            return X * vector.X + Y * vector.Y + Z * vector.Z;
        }
        public double AngleBetweenVectors(Vector vector)
        {
            return VectorScalar(vector) / Length() * vector.Length();
        }
        public void Equality(Vector vector)
        {
            if (X == vector.X &&
                Y == vector.Y &&
                Z == vector.Z)
                throw new Equals();

            throw new NotEquals();
        }
    }
}
