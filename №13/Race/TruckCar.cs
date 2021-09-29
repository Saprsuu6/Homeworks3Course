using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class TruckCar : Car
    {
        public TruckCar(string name, uint maxSpeed, int minSpeed) : base(name, maxSpeed, minSpeed) { }

        public override void ChangeColour() => Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
