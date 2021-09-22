using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    abstract class Builder : IWorker
    {
        protected string speciality;
        protected House house = new House();

        public Builder(string speciality) => this.speciality = speciality;

        public abstract void BiuldFundament();

        public abstract void BuildDoor();

        public abstract void BuildRoof();

        public abstract void BuildWalls();

        public abstract void BuildWindows();

        public House GetProduct()
        {
            return house;
        }        public string Speciality { get { return speciality; } }    }
}
