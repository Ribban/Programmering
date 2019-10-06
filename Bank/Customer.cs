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

        public Customer()
        {

        }
        public Customer(string Name, int Balance)
        {
            this.name = Name;
            this.balance = Balance;
        }

        public void SaveCustomer(string row)
        {
            string[] items = row.Split(',');
            this.name = items.First();
            this.balance = int.Parse(items.Last());
        }

        public string ShowCustomer()
        {
            return "Användare: " + name + " --- " + "Saldo: " + balance + "kr";
        }
    }
}
