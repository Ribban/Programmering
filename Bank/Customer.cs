using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        public string name { get; set; }

        public int balance { get; set; }

        public string ShowCustomer { get { return name + " " + balance; } }
    }
}
