using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D<double> point = new Point2D<double>(1, 2);
            ShowCoords<double> show = new ShowCoords<double>(point);
            show.Show();

            Point2D<double> point2 = new Point2D<double>(1, 6);
            ShowCoords<double> show2 = new ShowCoords<double>(point);
            show2.Show();

            Line<double> line = new Line<double>(point, point2);

            Line<double> line2 = new Line<double>(1, 2, 1, 6);

            ShowCoords<double> show3 = new ShowCoords<double>(line.Point1);
            show3.Show();
            ShowCoords<double> show4 = new ShowCoords<double>(line.Point2);
            show4.Show();
        }
    }
}
