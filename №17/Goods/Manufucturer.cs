using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Manufucturer
    {
        public Manufucturer(string country, DateTime date)
        {
            Country = country;
            Date = date;
        }

        public string Country{ get; set; }
        public DateTime Date { get; set; }
    }
}
