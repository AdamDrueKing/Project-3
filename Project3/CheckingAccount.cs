using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CheckingAccount : Accounts
    {
        //fields
        private string accountType = "CheckingAccount";
        private float balance = 1000000;
        private int accountNumber = 00001;

        //Properties
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
        public CheckingAccount()
        {
            //default constructor
        }

        public CheckingAccount(float accountBalance, int accountNumber)
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
