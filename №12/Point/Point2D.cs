using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point2D<T>
    {
        protected T x;
        protected T y;

        public Point2D() { }

        public Point2D(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T X { set { x = value; } get { return x; } }
        public T Y { set { y = value; } get { return y; } }

        public virtual double Z { set; get; }
    }
}
