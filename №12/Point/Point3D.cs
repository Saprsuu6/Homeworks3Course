using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point3D : Point2D<double>
    {
        private double z;

        public Point3D() { }

        public Point3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public override double Z { set { z = value; } get { return z; } }
    }
}
