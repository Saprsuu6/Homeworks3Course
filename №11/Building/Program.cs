using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderTeam team = new BuilderTeam();
            team.AddBuilder(new BuilderByWood("wood"));
            Director director = new Director(team["wood"]);
            director.StartBuilding();
            House house = director.GetHouse();
        }
    }
}
