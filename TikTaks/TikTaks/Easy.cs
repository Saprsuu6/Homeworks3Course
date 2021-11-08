using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTaks
{
    class Easy : Gameplay
    {
        Random rand = new Random();

        public Easy(bool first) : base(first) { }

        public override int SetFigureComputer()
        {
            int random;

            while (true)
            {
                random = rand.Next(0, 8);

                if (field[random] == 0)
                {
                    if (first)
                        field[random] = 2;
                    else
                        field[random] = 1;

                    break;
                }
            }

            return random;
        }
    }
}
