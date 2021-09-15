using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithDataBase;
using WorkWithAccount;

namespace WorkWithBaseManagemant
{
    class BaseManagemant
    {
        private DataBase @base;

        public BaseManagemant() => @base = new DataBase();
        public void AddToBase(Account account)
        {
            Account[] newArray = new Account[@base.Length + 1];
            for (int i = 0; i < @base.Length; i++)
            {
                newArray[i] = @base[i];
            }
            newArray[@base.Length] = account;

            @base.Array = newArray;
        }

        public void DeleteFromBase(string login)
        {
            if (@base.Length == 0)
                throw new ApplicationException("The base is empty.");

            for (int i = 0; i < @base.Length; i++)
            {
                if (@base[i].Login == login)
                {
                    Account[] newArray = new Account[@base.Length - 1];
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
                    throw new ApplicationException("The employer was deleted.");
                }
            }

            throw new ApplicationException("The employer wasn't found.");
        }

        public bool CheckForExistEmplioyer(string login)
        {
            for (int i = 0; i < @base.Length; i++)
            {
                if (@base[i].Login == login)
                {
                    return true;
                }
            }

            return false;
        }

        public Account Find(string login)
        {
            if (@base.Length == 0)
                throw new ApplicationException("Base is empty.");

            int temp = 0;

            for (int i = 0; i < @base.Length; i++)
            {
                if (@base[i].Login == login)
                {
                    temp = i;
                    break;
                }
                else if (i == @base.Length - 1)
                    throw new ApplicationException("Employer was not found.");
            }

            return @base[temp];
        }

        public int Length { get { return @base.Length; } }

        public Account this[int index]
        {
            get
            {
                return @base[index];
            }
        }
    }
}
