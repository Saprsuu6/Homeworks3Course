using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    abstract class Log : ILog
    {
        public virtual void Print(Storage st)
        {
            Console.WriteLine("User name - {0}\nModel - {1}\n" +
                "Model - {2}\nAmount - {3}",
                st.UserName, st.Capacity, st.Model, st.Amount);

            if (st is USB)
            {
                Console.WriteLine("Work speed - {0}", st.Field);
            }
            else if (st is DVD)
            {
                Console.WriteLine("Rotation speed - {0}", st.Field);
            }
            else if (st is HDD)
            {
                Console.WriteLine("Wiling speed - {0}", st.Field);
            }
        }
    }
}
