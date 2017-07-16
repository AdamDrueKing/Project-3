using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    abstract class Accounts
    {
        //fields
        public abstract float Withdrawl(float withdrawl);
        public abstract float Deposit(float deposit);

        //Constructor used to get balances for the checking and savings accounts
        public virtual void AccountBalance()
        {
        }


        //protected int accountNumber;
        //protected int accountBalance;
        //protected int accountType;

        ////properties
        //public double depositAmount { get; }
        //public double withdrawlAmount { get; }


        ////constructors
        //public Accounts()
        //{
        //    //default constructor
        //}
        //public Accounts(int accountNumber, int accountBalance, int accountType)
        //{
        //    this.accountNumber = accountNumber;
        //    this.accountBalance = accountBalance;
        //    this.accountType = accountType;
        //}

    }
}
