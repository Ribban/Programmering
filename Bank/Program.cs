using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Bank
{
    class Program
    {
        static List<Customer> customerList = new List<Customer>(); // Skapar en lista att spara alla customer objekt med hjälp av konstruktorn <list>

        static void Main(string[] args)
        {
            string filepath = @"E:\Hämtade filer\bank\Programmering\Bank\"; //Ger en fildestination
            string filename = @"Konton.txt"; //Ger ett filnamn
            string readfile = filepath + filename;
            ReadFile(filepath, filename); //Läser in nuvarande filen
            /// Kollar om filen som ska läsas in är korrekt
            try
            {
                if (File.Exists(readfile))
                {
                    string jsonText = File.ReadAllText(readfile);
                    if (jsonText != "")
                    {
                        customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonText);
                    }
                }
            }
            ///Ger ett felmeddelande ifall något går fel
            catch (Exception exc)
            {
                Console.WriteLine("");
                Console.WriteLine("Ett fel uppstod!");
                Console.WriteLine(exc.Message);
            }
            bool notDone = true; //Ger ett ja/nej värde
            while (notDone == true) { //Gör en loop tills notDone är false
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
                int choice = int.Parse(Console.ReadLine()); //Läser användarens input

                /// Väljer vilken kod som körs beroende på användarens input
                switch (choice)
                {
                    /// Lägger till en ny kund i customerList
                    case 1:
                        try
                        {
                            Customer customer = new Customer(); //Skapar en ny instans av klassen Customer med hjälp av konstruktorn "new Customer()"
                            Console.Write("Ange ditt namn: ");
                            customer.name = Console.ReadLine(); //Ger customer en string
                            Console.Write("Ange ditt nuvarande saldo: ");
                            customer.balance = int.Parse(Console.ReadLine()); //Ger customer en int
                            customerList.Add(customer); //Lägger till en ny customer i customerList
                            Console.WriteLine("Välkommen till vår bank " + customer.name);
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Någonting gick fel med att lägga till en användare");
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    /// Tar bort en kund ur customerList
                    case 2:
                        try
                        {
                            foreach (Customer item in customerList)
                            {
                                Console.WriteLine(item.name);
                            }
                            Console.Write("Vem vill du ta bort?");
                            int choise = int.Parse(Console.ReadLine()); //Ger choise ett värde
                            customerList.Remove(customerList[choise - 1]); //Kollar customerList och tar bort customer beroende på användarens input
                            Console.WriteLine("Tog bort användare.");
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Någonting gick fel med att ta bort en användare");
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    /// Visar allting i customerList
                    case 3:
                        foreach (Customer c in customerList) ///Visar alla customers i customerList
                        {
                            Console.WriteLine(c.name);
                        }
                        break;
                    /// Visar saldo för en enskild kund
                    case 4:
                        try
                        {
                            foreach (Customer c in customerList)
                            {
                                Console.WriteLine(c.name);
                            }
                            Console.Write("Vems saldo vill du visa? ");
                            int customerBalance = int.Parse(Console.ReadLine()); //Ger customerBalance ett värde
                            Console.WriteLine(customerList[customerBalance - 1].balance); //Kollar customerList och printar en customers balance beroende på användarens input
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Någonting gick fel med att ta bort en användare");
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    /// Lägger till pengar på en kunds konto
                    case 5:
                        try
                        {
                            Console.Write("Hos vem vill du göra en insättning?");
                            foreach (Customer c in customerList)
                            {
                                Console.WriteLine(c.name);
                            }
                            int customerBalance = int.Parse(Console.ReadLine());
                            Console.Write("Hur stor insättning vill du göra?");
                            var addBalance = int.Parse(Console.ReadLine()); //Nedan togs av Jonathan Eriksson och gjordes om för att passa min kod
                            customerList[customerBalance - 1].balance += addBalance; //Ändrar värdet i balance
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Någonting gick fel med att ta bort en användare");
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    /// Tar bort pengar från en kunds konto
                    case 6:
                        try
                        {
                            Console.Write("Hos vem vill du göra ett uttag?");
                            foreach (Customer c in customerList)
                            {
                                Console.WriteLine(c.name);
                            }
                            int customerBalance = int.Parse(Console.ReadLine());
                            Console.Write("Hur mycket vill du ta ut?");
                            var subBalance = int.Parse(Console.ReadLine()); //Ger subBalance ett värde
                            customerList[customerBalance - 1].balance += subBalance * -1; //Samma som ovan men adderar ett negativt tal
                        }
                        
                        catch (Exception exc)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Någonting gick fel med att ta bort en användare");
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    /// Avslutar programmet
                    case 7:
                        notDone = false; //Ger notDone värdet false så loopen blir klar
                        break;
                }
                

            }
            WriteFile(filepath, filename); //Skriver ut nuvarande listan i filen
        }
        /// Skriver ut customerList på fil
        private static void WriteFile(string filepath, string filename)
        {
            string f = filepath + filename; //Gör en ny sträng
            if (File.Exists(f)) //Om filen finns
            {
                File.Delete(f); //Ta bort filen
            }
            if (Directory.Exists(filepath) == false) //Om destinationen inte finns
            {
                Directory.CreateDirectory(filepath); //Skapa destinationen
            }
            string appendText = ""; //Gör en tom sträng
            foreach (Customer item in customerList) //Läser in listan
            {
                appendText += item.ShowCustomer() + Environment.NewLine; //Skriver in listan på den tomma strängen på olika rader
            }
            File.AppendAllText(f, appendText); //Skriver ut filen
        }
        /// Läser in filen och skriver innehållet på customerList
        private static void ReadFile(string filepath, string filename) //Instruktioner för readFile
        {
            string f = filepath + filename;
            if (File.Exists(f)) //Kollar om filen finns
            {
                string[] rows = File.ReadAllLines(f); //Läser alla rader i filen
                foreach (string item in rows) //En loop för varje rad
                {
                    Customer customer = new Customer();
                    customer.SaveCustomer(item); //Kör koden som skriver in customer
                    customerList.Add(customer); //Lägger till raden i listan
                }
            }
        }

    }
}
