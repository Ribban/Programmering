using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customer
    {
        public string name { get; set; }

        public int balance { get; set; }

        public string ShowCustomer { get { return name + " " + balance; } }
    }
}
