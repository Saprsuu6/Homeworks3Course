using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Director
    {
        private Builder builder;

        public Director(Builder builder) => this.builder = builder;

        public void StartBuilding()
        {
            builder.BiuldFundament();
            builder.BuildWalls();
            builder.BuildDoor();
            builder.BuildWindows();
            builder.BuildRoof();
        }

        public House GetHouse()
        {
            House house = builder.GetProduct();

            house.Basemant.Print();
            foreach (Wall item in house.Walls)
                item.Print();
            house.Door.Print();
            foreach (Window item in house.Windows)
                item.Print();
            house.Roof.Print();

            return house;
        }
    }
}
