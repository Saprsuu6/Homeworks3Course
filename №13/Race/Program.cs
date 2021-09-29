using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = { new SportCar("Markus", 300, -20), new SportCar("Andry", 300, -20) };
            Gameplay gameplay = new Gameplay(ref cars);

            gameplay.ev += gameplay.Strat;
            gameplay.ev += gameplay.End;
            gameplay.ev += gameplay.Progress;
            gameplay.ev += gameplay.Winner;

            gameplay.Execute();
        }
    }
}
