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
                     
                }
            }





           // Client clientOne = new Client("John Smith", "123 Main St", 2165551234);
     
            // Console.WriteLine(clientOne);
        }
    }
}
