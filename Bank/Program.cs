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
                        customerList.Add(customer);
                        Console.WriteLine("Välkommen till vår bank " + customer.name);
                        break;
                    case 2:
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.ShowCustomer);
                        }
                        Console.Write("Vem vill du ta bort?");
                        int choise = int.Parse(Console.ReadLine());
                        customerList.Remove(customerList[choise - 1]);
                        Console.WriteLine("Tog bort användare.");
                        break;
                    case 3:
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        break;
                    case 4:
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        Console.Write("Vems saldo vill du visa? ");
                        int customerBalance = int.Parse(Console.ReadLine());
                        Console.WriteLine(customerList[customerBalance - 1]);
                        break;
                    case 5:
                        Console.Write("Hos vem vill du göra en insättning?");
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        customerBalance = int.Parse(Console.ReadLine());
                        Console.Write("Hur stor insättning vill du göra?");
                        var addBalance = int.Parse(Console.ReadLine());
                        customerList[customerBalance - 1].transaction.Add(addBalance);
                        customerList[customerBalance - 1].balance += addBalance;
                        break;
                    case 6:
                        Console.Write("Hos vem vill du göra ett uttag?");
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        customerBalance = int.Parse(Console.ReadLine());
                        Console.Write("Hur mycket vill du ta ut?");
                        var subBalance = int.Parse(Console.ReadLine());
                        customerList[customerBalance - 1].transaction.Add(subBalance * -1);
                        customerList[customerBalance - 1].balance += subBalance * -1;
                        break;
                    case 7:
                        notDone = false;
                        break;
                }
            
            }
        }
    }
}
