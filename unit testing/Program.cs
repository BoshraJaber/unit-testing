using System;

namespace ATM
{
   public class Program
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
                    Console.WriteLine(Withdraw(Convert.ToDecimal(money)));
                }
                else if (userInput == "2")
                {
                    Console.Write("Please enter amount of money > ");
                    string money = Console.ReadLine();
                    Console.WriteLine(Deposit(Convert.ToDecimal(money)));
                }
                else if(userInput == "4")
                {
                    Console.WriteLine($"Thank you {userName}, Have a nice day");
                    showInterface = false;
                }
                else
                {
                    Console.WriteLine("Kindly choose one of the numbers from 1 to 4");
                }

            }
           
        }
        // View Balance
        static public decimal ViewBalance()
        {
            return Balance;
        }
        // Deposite:
        static public string Deposit(decimal deposite)
        {
            try
            {
                if (deposite <= 0)
                {

                    throw new Exception("Invalid Number, please enter a valid number");
                }

                Balance += deposite;
                return "Task completed successfully";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        // withdraw;
        static public string Withdraw(decimal withdraw)
        {
            try
            {

                if (withdraw > Balance)
                {
                    throw new Exception($"{withdraw} is greater than what you have, your balance {Balance}");
                }

                if (withdraw <= 0)
                {

                    throw new Exception("Invalid Number, Please enter a number above 0");
                }

                Balance -= withdraw;
                return "Task Completed Successfully";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


    }
}
