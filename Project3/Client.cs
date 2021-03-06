﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Client
    {
        //fields 
        //client information used to populate user field.
        public string clientName = "John Smith";
        public string clientAddress = "123 Main Street";
        public string clientPhone = "216-555-1234";
        public float checkingAccountNumber = 00001;
        public float savingsAccountNumber = 00002;

        //properties
        //used to populate the input
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }

        public string ClientAddress
        {
            get { return this.clientAddress; }
            set { this.clientAddress = value; }
        }

        public string ClientPhone
        {
            get { return this.clientPhone; }
            set { this.clientPhone = value; }
        }

        public float CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
            set { this.checkingAccountNumber = value; }
        }

        public float SavingsAccountNumber
        {
            get { return this.savingsAccountNumber; }
            set { this.savingsAccountNumber = value; }
        }


        //Constructors
        public Client()
        {
            //default constructor
        }

        public Client(string name, string address, string phoneNumber)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
        }
        
        //Methods
        //the "verbs".
        public void ClientInformation()
        {
            Console.WriteLine("Client name: " + clientName);
            Console.WriteLine("Client address: " + clientAddress);
            Console.WriteLine("Client phone number: " + clientPhone);
            Console.WriteLine("Client Checking Account Number: " + checkingAccountNumber);
            Console.WriteLine("Client Savings Account Number: " + savingsAccountNumber);
        }

    }
}
