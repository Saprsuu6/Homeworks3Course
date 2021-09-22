using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class BuilderByWood : Builder
    {
        public BuilderByWood(string speciality) : base(speciality) { }

        public override void BiuldFundament()
        {
            house.Basemant = new Basemant("10m", "20m", "2m");
        }

        public override void BuildDoor()
        {
            if (house.Walls != null)
            {
                house.Door = new Door("1m", "2m", "wood", "3");
            }
        }

        public override void BuildRoof()
        {
            if (house.Windows != null)
            {
                house.Roof = new Roof("10m", "20m", "wood", "conus");
            }
        }

        public override void BuildWalls()
        {
            if (house.Basemant != null)
            {
                Wall[] walls = new Wall[4];
                for (int i = 0; i < walls.Length; i++)
                {
                    walls[i] = new Wall("10m", "20m", "wood");
                }

                house.Walls = walls;
            }
        }

        public override void BuildWindows()
        {
            if (house.Door != null)
            {
                Window[] windows = new Window[4];
                for (int i = 0; i < windows.Length; i++)
                {
                    windows[i] = new Window("1m", "1m", "wood", "open/close");
                }

                house.Windows = windows;
            }
        }
    }
}
