using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 50000, deposit, withdraw;

            int choice, pin = 0, x = 0;
            Console.WriteLine("Please enter your pin number ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("*******ABC Bank Welcomes You********\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Make a Withdrawal\n");
                Console.WriteLine("3. Make a Deposit\n");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Please enter a choice:  ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Your Balance is {0} dollars", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n Enter the amount to withdraw:  ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 10 != 0)
                        {
                            Console.WriteLine("\n Please use a multiple of 10");
                        }
                        else if (withdraw > (amount))
                        {
                            Console.WriteLine("\n You do not have sufficient funds for this withdrawal");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n Please Take Cash");
                            Console.WriteLine("\n Current balance is now {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Enter the amount to deposit");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Current balance is now {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n Thanks for using 123 Bank ATM service! Press any key to exit");
                        break;

                        {
                            Console.ReadKey();
                        }

                }
            }

        }
    }
}
