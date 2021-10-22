using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOIL.Classes
{
    class Oil
    {
        private string[] oilName = { "АИ-80", "АИ-92", "АИ-95", "АИ-95+" };
        private double[] prices = { 31.45, 32.93, 42.18, 43.18 };

        public string[] OilName { get => oilName; }
        public double[] Prices { get => prices; }
    }
}
