using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithAccount;

namespace WorkWithDataBase
{
    class DataBase
    {
        private Account[] array;

        public DataBase() => array = new Account[0];
        public int Length { get { return array.Length; } } 
        public Account[] Array { set { array = value; } }

        public Account this[int index]
        {
            get
            {
                return array[index];
            }
        }
    }
}
