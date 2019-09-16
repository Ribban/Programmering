using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static List<Customer> customerList = new List<Customer>();

        static void Main(string[] args)
        {
            bool notDone = true;
            while (notDone == true) {
                Console.WriteLine("Välkommen till banken!");
                Console.WriteLine("Ange vilket av följande alternativ du önskar göra.");
                Console.WriteLine("1 : Lägg till en användare");
                Console.WriteLine("2 : Ta bort en användare");
                Console.WriteLine("3 : Visa alla befintliga användare");
                Console.WriteLine("4 : Visa saldo för en användare");
                Console.WriteLine("5 : Gör en insättning för en användare");
                Console.WriteLine("6 : Gör ett uttag för en användare");
                Console.WriteLine("7 : Avsluta programmet");
                Console.WriteLine(" ");
                Console.Write("Skriv ditt val:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.Write("Ange ditt namn: ");
                        customer.name = Console.ReadLine();
                        Console.Write("Ange ditt nuvarande saldo: ");
                        customer.balance = int.Parse(Console.ReadLine());
                        Console.WriteLine("Välkommen till vår bank " + customer.name);
                        customerList.Add(customer);
                        break;
                    case 2:

                        break;
                    case 3:
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.ShowCustomer);
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        notDone = false;
                        break;
                }
            
            }
        }
    }
}
