using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithBaseManagemant;
using WorkWithRegular;
using WorkWithAccount;

namespace WorkWithRegistration
{
    class RegistrationForm
    {
        private string login;
        private string passWord;
        private bool isValid;
        private Regular regular;
        private BaseManagemant mng;
        private int counter = 0;

        private void Input()
        {
            Console.Write("Enter your login: ");
            login = Console.ReadLine();

            Console.Write("Enter your password: ");
            passWord = Console.ReadLine();
        }

        public RegistrationForm(BaseManagemant mng, Regular regular)
        {
            this.regular = regular;
            this.mng = mng;
        }

        public void Attemp()
        {
            counter++;
            Input();

            if (mng.CheckForExistEmplioyer(login))
            {
                throw new ApplicationException("Employer whith login like that already exists.");
            }

            isValid = regular.HasLowerChar.IsMatch(passWord) &&
                regular.HasNumber.IsMatch(passWord) &&
                !regular.HasSymbols.IsMatch(passWord) &&
                regular.HasUpperChar.IsMatch(passWord);

            if (isValid)
            {
                mng.AddToBase(new Account(login, passWord));
            }
            else
            {
                if (counter == 3)
                {
                    throw new ApplicationException("Amount of attempts is over.");
                }
                throw new ApplicationException("Unvalid password! Try again");
            }
        }

        public string Login { get { return login; } }
    }
}
