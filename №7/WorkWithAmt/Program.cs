using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithBaseManagemant;
using WorkWithAccount;
using WorkWithRegistration;
using WorkWithRegular;
using WorkWithAutorisation;

namespace WorkWithAmt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temp = false;
            string login = "";

            BaseManagemant mng = new BaseManagemant();
            ShowBase show = new ShowBase(mng);
            Regular regular = new Regular();

            Console.WriteLine("1. Sing up.");
            Console.WriteLine("2. Sing in.");
            Console.WriteLine("Make a choose: ");

            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        RegistrationForm registration = new RegistrationForm(mng, regular);
                        Console.WriteLine("You have only three attemps.");
                        registration.Attemp();
                        login = registration.Login;
                        temp = true;
                        break;

                    case 2:
                        AutorisationForm autorisation = new AutorisationForm(mng, regular);
                        Console.WriteLine("You have only three attemps.");
                        autorisation.Attemp();
                        login = autorisation.Login;
                        temp = true;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (temp)
            {
                AMT amt = new AMT(mng.Find(login));

                Console.WriteLine("1. Find out info.");
                Console.WriteLine("2. Top up account.");
                Console.WriteLine("3. Withdraw cash. ");
                Console.WriteLine("3. Log out. ");

                while (true)
                {
                    try
                    {
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("Your login - {0}\nYour cash is {1}",
                                    login, amt.ClientCash);
                                break;

                            case 2:
                                Console.WriteLine("Enter the sum: ");
                                amt.TopUpAccount(Convert.ToUInt32(Console.ReadLine()));
                                break;

                            case 3:
                                Console.WriteLine("Enter the sum (0-{0}): ", amt.Cash);
                                uint sum = Convert.ToUInt32(Console.ReadLine());
                                if (sum < amt.Cash)
                                {
                                    amt.WithDrawCash(sum);
                                }
                                Console.WriteLine(sum);
                                break;
                            case 4:
                                Console.WriteLine("Do u want to exit 1-Yes 2-No: ");
                                uint number = Convert.ToUInt32(Console.ReadLine());
                                if (number == 1)
                                {
                                    temp = false;
                                }
                                break;
                        }

                        if (!temp)
                        {
                            break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
