using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BankofOne!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1.View Client Information" + "\n" + "2.View Account Balance" + "\n" + "3.Deposit Funds" + "\n" + "4.Withdraw Funds" + "\n" + "5.Exit");
            string userOption;
            string userFollowUp;
            userOption = Console.ReadLine();
            do
            {
                if (userOption == "1") ;
                {
                    Console.WriteLine(ClientInformation());
                    Console.WriteLine("Please press the enter key when done.");
                }

                if (userOption == "2") ;
                {
                    Console.WriteLine("Would you like to view your checking, or savings, account?");
                    userFollowUp = Console.ReadLine();
                    if (userFollowUp == "checking") ;
                    {
                        Console.WriteLine("Your checking account balance is: " + accountBalance);
                    }
                    if (userFollowUp == "savings");
                    {
                        Console.WriteLine("Your savings account balance is: " + accountBalance);
                    }
                }
                while (userFollowUp != "1" || userFollowUp != "2") ;
            }
            
            if (userOption == "3")
            {
                do
                {
                    Console.WriteLine("Which account would you like to make your deposit?");
                    userFollowUp = Console.ReadLine();
                    if (userFollowUp == "checking") ;
                    {
                        Console.WriteLine("How much would you like to deposit?")
                           deposit = float.Parse(Console.ReadLine());
                        checkingAccountBalance = accountBalance + deposit;
                        Console.WriteLine("Your new balance is: " + checkingAccountBalance);
                        Console.WriteLine("Please press enter when done.");
                    }
                    if (userFollowUp == "savings") ;
                    {
                        Console.WriteLine("How much would you like to deposit?")
                           deposit = float.Parse(Console.ReadLine());
                        savingsAccountBalance = accountBalance + deposit;
                        Console.WriteLine("Your new balance is: " + savingsAccountBalance);
                        Console.WriteLine("Please press enter when done.");
                    }

                }
                while (userFollowUp != "1" || userFollowUp != "2");

                if (userOption == "4") ;
                {
                    do
                    {
                        Console.WriteLine("Which account would you like to withdraw from?");
                        userFollowUp = Console.ReadLine();
                        if (userFollowUp == "checking") ;
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                               withdrawl = float.Parse(Console.ReadLine());
                            checkingAccountBalance = accountBalance - withdrawl;
                            Console.WriteLine("Your new balance is: " + checkingAccountBalance);
                            Console.WriteLine("Please press enter when done.");
                        }
                        if (userFollowUp == "savings") ;
                        {
                            Console.WriteLine("How much would you like to withdraw?")
                               withdrawl = float.Parse(Console.ReadLine());
                            savingsAccountBalance = accountBalance - deposit;
                            Console.WriteLine("Your new balance is: " + savingsAccountBalance);
                            Console.WriteLine("Please press enter when done.");
                        }

                    }
                    while (userFollowUp != "1" || userFollowUp != "2");

                    if (userOption == "5") ;
                    {
                        Console.WriteLine("Thank you for your patronage of BankOfOne");
                    }
                }

            }
            }





           
        }
    }
}
