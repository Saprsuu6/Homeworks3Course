using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    sealed class ShowCoords<T>
    {
        private Point2D<T> point;

        public ShowCoords(Point2D<T> point) => this.point = point;

        public void Show()
        {
            Console.WriteLine("x - {0}, y - {1}, z - {2}", point.X, point.Y, point.Z);
        }
    }
}
