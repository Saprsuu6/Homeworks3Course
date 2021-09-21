using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class BaseManagemant
    {
        private StorageBase @base;

        public BaseManagemant() => @base = new StorageBase();

        public void AddStorage(Storage goods)
        {
            Storage[] newBase = new Storage[@base.Length + 1];
            for (int i = 0; i < @base.Length; i++)
            {
                newBase[i] = @base[i];
            }
            newBase[@base.Length] = goods;

            @base.Array = newBase;
        }

        public void DeleteGoods(string name)
        {
            if (@base.Length == 0)
                throw new ApplicationException("The base is empty.");

            for (int i = 0; i < @base.Length; i++)
            {
                if (@base[i].Model == name)
                {
                    Storage[] newArray = new Storage[@base.Length - 1];
                    for (int j = 0; j < @base.Length - 1; j++)
                    {
                        if (j < i)
                        {
                            newArray[j] = @base[j];
                            continue;
                        }
                        newArray[i] = @base[j + 1];
                    }

                    @base.Array = newArray;
                    throw new ApplicationException("The storage was deleted.");
                }
            }
        }

        public Storage FindByModel(string model)
        {
            return @base[model];
        }

        public void MakeLogic(Storage st, int temp)
        {
            Log lg;

            if (temp == 1)
            {
                lg = new Binary();
            }
            else if (temp == 2)
            {
                lg = new Binary();
            }
            else if (temp == 3)
            {
                lg = new Binary();
            }
            else
            {
                throw new ApplicationException("Choose correct type of print.");
            }

            lg.Print(st);
        }

        public int Length { get { return @base.Length; } }
    }
}
