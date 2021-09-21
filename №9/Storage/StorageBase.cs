using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class StorageBase
    {
        private Storage[] array;

        public StorageBase() => this.array = new Storage[0];
        public int Length { get { return array.Length; } }
        public Storage[] Array { set { array = value; } }
        public Storage this[int index]
        {
            get
            {
                return array[index];
            }
        }
        public Storage this[string model]
        {
            get
            {
                if (array.Length == 0)
                    throw new ApplicationException("Base is empty.");

                int temp = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Model == model)
                    {
                        temp = i;
                        break;
                    }
                    else if (i == array.Length - 1)
                        throw new ApplicationException("Storage was not found.");
                }

                return array[temp];
            }
        }
    }
}
