using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class SavingsAccount : Accounts
    {
        //Same setup as CheckingAccount Class

        //fields
        //account information used to populate user field.
        private string accountType = "SavingsAccount";
        private float balance = 1000000;
        private int accountNumber = 00002;

        //Properties
        //used to populate the input
        public float AccountBalance
        {
            get { return this.AccountBalance; }
            set { this.AccountBalance = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(float accountBalance, int accountNumber)
        {
            this.AccountBalance = accountBalance;
            this.accountNumber = accountNumber;
        }

        //Methods to deposit/withdrawl and get balance ***thanks for the heads up, Jonathan!!!
        public override float Deposit(float deposit)
        {
            return deposit = deposit + AccountBalance;
            //thanks for explaining what this equation means, Lauren!!!
        }

        public override float Withdrawl(float withdrawl)
        {
            return balance = balance - withdrawl;
        }

        public override void NewBalance()
        {
            //base.AccountBalance();
            //Console.WriteLine
        }

    }
}
