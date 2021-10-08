using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Chracteristics
    {
        public Chracteristics(string power, string modelCharacteristics, string addCharacteristics)
        {
            Power = power;
            ModelCharacteristics = modelCharacteristics;
            AddCharacteristics = addCharacteristics;
        }

        public string Power { get; set; }
        public string ModelCharacteristics { get; set; }
        public string AddCharacteristics { get; set; }
    }
}
