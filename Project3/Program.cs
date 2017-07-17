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
            //Welcome screen for the program
            Console.WriteLine("Welcome to BankofOne!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1.View Client Information" + "\n" + "2.View Account Balance" + "\n" + "3.Deposit Funds" + "\n" + "4.Withdraw Funds" + "\n" + "5.Exit");
            //preparing for user responses to prompts (userOption is response to first prompt, userFollowUp is response to second set of prompts
            string userOption;
            string userFollowUp;
            //initating userOption from user response.
            userOption = Console.ReadLine();
            //Do-While loop to start program based on user responses
            do
            {
                //user entering option "1" to print user information. ClientInformation from Client class not printing as I'd hoped.
                if (userOption == "1") ;
                {
                    Console.WriteLine(ClientInformation));
                    Console.WriteLine("Please press the enter key when done.");
                }

                //user entering option "2" to view account information.
                if (userOption == "2") ;
                {
                    Console.WriteLine("Would you like to view your checking, or savings, account?");
                    userFollowUp = Console.ReadLine();
                    //if user selects checking account to view
                    if (userFollowUp == "checking") ;
                    {
                        Console.WriteLine("Your checking account balance is: " + accountBalance);
                    }
                    //user selects savings account to view
                    if (userFollowUp == "savings");
                    {
                        Console.WriteLine("Your savings account balance is: " + accountBalance);
                    }
                }
                //do the above as long as the second prompt doesn't equal 1, or 2.
                while (userFollowUp != "1" || userFollowUp != "2") ;
            }
            
            //if the user wants to make a deposit
            if (userOption == "3")
            {
                do
                    //do the below
                {
                    Console.WriteLine("Which account would you like to make your deposit?");
                    userFollowUp = Console.ReadLine();
                    //user wants to deposit into checking account
                    if (userFollowUp == "checking") ;
                    {
                        Console.WriteLine("How much would you like to deposit?")
                           deposit = float.Parse(Console.ReadLine());
                        checkingAccountBalance = accountBalance + deposit;
                        Console.WriteLine("Your new balance is: " + checkingAccountBalance);
                        Console.WriteLine("Please press enter when done.");
                    }
                    //user wants to deposit into the savings account
                    if (userFollowUp == "savings") ;
                    {
                        Console.WriteLine("How much would you like to deposit?")
                           deposit = float.Parse(Console.ReadLine());
                        savingsAccountBalance = accountBalance + deposit;
                        Console.WriteLine("Your new balance is: " + savingsAccountBalance);
                        Console.WriteLine("Please press enter when done.");
                    }

                }
                //do the above while the user prompt response is not 1, or 2.
                while (userFollowUp != "1" || userFollowUp != "2");

                //same as prompt response 3, but for withdrawl, not deposit
                if (userOption == "4") ;
                {
                    do
                        //do the below
                    {
                        Console.WriteLine("Which account would you like to withdraw from?");
                        userFollowUp = Console.ReadLine();
                        //user wants to withdraw from checking
                        if (userFollowUp == "checking") ;
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                               withdrawl = float.Parse(Console.ReadLine());
                            checkingAccountBalance = accountBalance - withdrawl;
                            Console.WriteLine("Your new balance is: " + checkingAccountBalance);
                            Console.WriteLine("Please press enter when done.");
                        }
                        //user wants to withdraw from savings
                        if (userFollowUp == "savings") ;
                        {
                            Console.WriteLine("How much would you like to withdraw?")
                               withdrawl = float.Parse(Console.ReadLine());
                            savingsAccountBalance = accountBalance - deposit;
                            Console.WriteLine("Your new balance is: " + savingsAccountBalance);
                            Console.WriteLine("Please press enter when done.");
                        }

                    }
                    //while user prompt response isn't 1 or 2.
                    while (userFollowUp != "1" || userFollowUp != "2");

                    //user wants to exit program
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
