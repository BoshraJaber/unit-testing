using System;

namespace ATM
{
    class Program
    {
        // Global variable 
        static public decimal Balance = 0;
        static void Main(string[] args)
        {
            UserInterface();
        }

        // user interface:

          public static void UserInterface()
        {
            Boolean showInterface = true;
            Console.WriteLine("Hello to our ATM, Kindly enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine($"Please select one of the options  {userName}:");
            Console.WriteLine("Press 1 to view your Balance");
            Console.WriteLine("Press 2 to Deposit");
            Console.WriteLine("Press 3 to withdraw");
            Console.WriteLine("Press 4 to Exit");

            while (showInterface)
            {
              
                string userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    Console.WriteLine(ViewBalance());
                }
                else if(userInput == "3")
                {
                    Console.Write("Please enter amount of money > ");
                    string money = Console.ReadLine();
                    //Console.WriteLine(Withdraw(Convert.ToDecimal(money)));
                }
                else if (userInput == "2")
                {
                    Console.Write("Please enter amount of money > ");
                    string money = Console.ReadLine();
                 //   Console.WriteLine(Deposit(Convert.ToDecimal(money)));
                }
                else if(userInput == "4")
                {
                    Console.WriteLine("Thank you");
                    showInterface = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            }
           
        }
        static public decimal ViewBalance()
        {
            return Balance;
        }
    }
}
