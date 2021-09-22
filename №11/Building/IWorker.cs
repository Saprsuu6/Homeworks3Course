using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    interface IWorker
    {
        void BiuldFundament();
        void BuildWalls();
        void BuildWindows();
        void BuildDoor();
        void BuildRoof();
        House GetProduct();
    }
}
