using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static List<Customer> customerList = new List<Customer>();

        static void Main(string[] args)
        {
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
            int choise = int.Parse(Console.ReadLine());

            switch(choise)
        }
    }
}
