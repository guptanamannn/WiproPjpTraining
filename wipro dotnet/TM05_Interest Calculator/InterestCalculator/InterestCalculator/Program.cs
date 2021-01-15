using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    interface Account
    {
        void CalculateInterest();

    }
    class FDAccount : Account
    {
        double Interest_rate;
        double Amount;
        int No_of_days;
        int Age;
        public void CalculateInterest()
        {
            try
            {
                Console.WriteLine("Enter the FD Amount");
                Amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter no of days:");
                No_of_days = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your age:");
                Age = int.Parse(Console.ReadLine());

                if (No_of_days > 0)
                {
                    if (Amount <= 10000000)
                    {
                        if (Age > 60)
                        {
                            if (No_of_days >= 7 && No_of_days <= 14)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 5) / 100);
                            }
                            else if (No_of_days >= 15 && No_of_days <= 29)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 5.25) / 100);
                            }
                            else if (No_of_days >= 30 && No_of_days <= 45)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 6) / 100);
                            }
                            else if (No_of_days >= 45 && No_of_days <= 60)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 7.50) / 100);
                            }
                            else if (No_of_days >= 61 && No_of_days <= 184)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 8) / 100);
                            }
                            else if (No_of_days >= 184 && No_of_days <= 366)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 8.50) / 100);
                            }
                            else
                            {

                            }

                        }
                        else
                        {
                            if (No_of_days >= 7 && No_of_days <= 14)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 4.50) / 100);
                            }
                            else if (No_of_days >= 15 && No_of_days <= 29)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 4.75) / 100);
                            }
                            else if (No_of_days >= 30 && No_of_days <= 45)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 5.50) / 100);
                            }
                            else if (No_of_days >= 45 && No_of_days <= 60)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 7) / 100);
                            }
                            else if (No_of_days >= 61 && No_of_days <= 184)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 7.50) / 100);
                            }
                            else if (No_of_days >= 184 && No_of_days <= 366)
                            {
                                Console.WriteLine("Interest gained is:Rs." + (this.Amount * 8) / 100);
                            }
                            else
                            {

                            }

                        }

                    }
                    else
                    {
                        if (No_of_days >= 7 && No_of_days <= 14)
                        {
                            Console.WriteLine("Interest gained is:Rs." + (this.Amount * 6.5) / 100);
                        }
                        else if (No_of_days >= 15 && No_of_days <= 29)
                        {
                            Console.WriteLine("Interest gained is:Rs." + (this.Amount * 6.75) / 100);
                        }
                        else if (No_of_days >= 30 && No_of_days <= 45)
                        {
                            Console.WriteLine("Interest gained is:Rs." + (this.Amount * 6.75) / 100);
                        }
                        else if (No_of_days >= 45 && No_of_days <= 60)
                        {
                            Console.WriteLine("Interest gained is:Rs." + (this.Amount * 8) / 100);
                        }
                        else if (No_of_days >= 61 && No_of_days <= 184)
                        {
                            Console.WriteLine("Interest gained is:Rs." + (this.Amount * 8.50) / 100);
                        }
                        else if (No_of_days >= 184 && No_of_days <= 366)
                        {
                            Console.WriteLine("Interest gained is:Rs." + (this.Amount * 10) / 100);
                        }
                        else
                        {

                        }

                    }

                }
                else
                {
                    throw new myexception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }

    }
    class myexception : Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid Number of days. Please enter correct values";
            }
        }
    }
    class SBAccount : Account
    {
        double Interest_rate;
        double Amount;
        public void CalculateInterest()
        {
            Console.WriteLine("Enter the Average amount in your account");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate : For normal account it is 4% and for nri account it is 6%");
            Interest_rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Interest gained:Rs." + (this.Amount * this.Interest_rate) / 100);
        }

    }
    class RDAccount : Account
    {
        double Interest_rate;
        double Amount;
        public void CalculateInterest()
        {
            Console.WriteLine("Enter amount in your account ");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate");
            Interest_rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Interest gained:Rs." + (this.Amount * this.Interest_rate) / 100);


        }
    }
    class Abstract
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the option" + "\n" + "     1.  Interest Calculator-SB" + "\n" + "     2.  Interest Calculator-FD" + "\n" + "     3.  Interest Calculator-RD" + "\n" + "     4.  Exit");

            bool close = true;
            while (close)
            {
                int Option = int.Parse(Console.ReadLine());
                if (Option == 1)
                {
                    FDAccount fd = new FDAccount();
                    fd.CalculateInterest();
                    break;
                }
                else if (Option == 2)
                {
                    SBAccount sb = new SBAccount();
                    sb.CalculateInterest();
                    break;
                }
                else if (Option == 3)
                {
                    RDAccount rd = new RDAccount();
                    rd.CalculateInterest();
                    break;
                }
                else if (Option == 4)
                {
                    close = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Correct Option");
                    break;
                }
            }
            Console.ReadKey();
        }

    }

}
