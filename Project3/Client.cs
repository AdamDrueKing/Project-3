using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Client
    {
        //fields
        public string clientName;
        public string clientAddress;
        public double clientPhone;

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public string ClientAddress
        { get { return this.clientAddress; }
            set { this.clientAddress = value; }
        }
        public double ClientPhone
        { get { return this.clientPhone; }
            set { this.clientPhone = value; }
        }

        //constructors
        public Client()
        {
        //default constructor
        }
        public Client(string clientName, string clientAddress, double clientPhone)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientPhone = clientPhone;
        }

        //public override string AllClientInfo()
        //{
            
          //  return clientName + clientAddress + clientPhone;



        }
}
