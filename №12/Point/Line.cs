using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Line<T>
    {
        private Point2D<T> point1;
        private Point2D<T> point2;

        private Line()
        {
            point1 = new Point2D<T>();
            point2 = new Point2D<T>();
        }

        public Line(Point2D<T> point1, Point2D<T> point2) : this()
        {
            this.point1.X = point1.X;
            this.point1.Y = point1.Y;

            this.point2.X = point2.X;
            this.point2.Y = point2.Y;
        }

        public Line(T x, T y, T x1, T y1) : this()
        {
            point1.X = x;
            point1.Y = y;

            point2.X = x1;
            point2.Y = y1;
        }

        public Point2D<T> Point1 { set { point1 = value; } get { return point1; } }
        public Point2D<T> Point2 { set { point2 = value; } get { return point2; } }
    }
}
