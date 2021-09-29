using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Gameplay
    {
        private List<MyDelegate> list = new List<MyDelegate>();
        private Car[] cars;

        public Gameplay(ref Car[] cars) => this.cars = cars;

        public event MyDelegate ev { add { list.Add(value); } remove { list.Remove(value); } }

        public void Execute()
        {
            foreach (MyDelegate item in list)
            {
                item.Invoke();
            }
        }

        public void Progress()
        {
            int i = 0;

            foreach (Car item in cars)
            {
                Console.WriteLine("Car {0} progress {1}%", item.Name, item.Progress);
                i++;
            }
        }
        public void Winner()
        {
            if (list.Count >= 2)
            {
                Car winner = null;

                for (int i = 0; i < cars.Length - 1; i++)
                {
                    if (cars[i].Progress >= cars[i + 1].Progress)
                        winner = cars[i];
                }

                Console.WriteLine("Winnder is {0}", winner.Name);
            }
        }
        public void Strat()
        {
            foreach (Car item in cars)
            {
                item.ev += item.EngineOn;
                item.ev += item.Go;

                item.StratEnd();
            }
        }
        public void End()
        {
            foreach (Car item in cars)
            {
                item.ev -= item.EngineOn;
                item.ev -= item.Go;

                item.ev += item.Stop;
                item.ev += item.EngineOff;

                item.StratEnd();
            }
        }
    }
}
