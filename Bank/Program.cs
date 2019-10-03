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
        static List<Customer> customerList = new List<Customer>();

        static void Main(string[] args)
        {
            string filepath = @"C:\Users\eliagrun\Desktop\Programering\Git\Bank\";
            string filename = @"bank.txt";
            string readFile = filepath + filename;
            try
            {
                if (File.Exists(readFile))
                {
                    string jsonText = File.ReadAllText(readFile);
                    if(jsonText != "")
                    {
                        customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonText);
                    }
                }
            }
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

                switch (choice) //Väljer vilken kod som körs beroende på användarens input
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.Write("Ange ditt namn: ");
                        customer.name = Console.ReadLine(); //Ger customer en string
                        Console.Write("Ange ditt nuvarande saldo: ");
                        customer.balance = int.Parse(Console.ReadLine()); //Ger customer en int
                        customerList.Add(customer); //Lägger till en ny customer i customerList
                        Console.WriteLine("Välkommen till vår bank " + customer.name);
                        break;
                    case 2:
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.ShowCustomer);
                        }
                        Console.Write("Vem vill du ta bort?");
                        int choise = int.Parse(Console.ReadLine()); //Ger choise ett värde
                        customerList.Remove(customerList[choise - 1]); //Kollar customerList och tar bort customer beroende på användarens input
                        Console.WriteLine("Tog bort användare.");
                        break;
                    case 3:
                        foreach (Customer c in customerList) ///Visar alla customers i customerList
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
                        int customerBalance = int.Parse(Console.ReadLine()); //Ger customerBalance ett värde
                        Console.WriteLine(customerList[customerBalance - 1].balance); //Kollar customerList och printar en customers balance beroende på användarens input
                        break;
                    case 5:
                        Console.Write("Hos vem vill du göra en insättning?");
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        customerBalance = int.Parse(Console.ReadLine());
                        Console.Write("Hur stor insättning vill du göra?");
                        var addBalance = int.Parse(Console.ReadLine()); //Nedan togs av Jonathan Eriksson och gjordes om för att passa min kod
                        customerList[customerBalance - 1].balance += addBalance; //Ändrar värdet i balance
                        break;
                    case 6:
                        Console.Write("Hos vem vill du göra ett uttag?");
                        foreach (Customer c in customerList)
                        {
                            Console.WriteLine(c.name);
                        }
                        customerBalance = int.Parse(Console.ReadLine());
                        Console.Write("Hur mycket vill du ta ut?");
                        var subBalance = int.Parse(Console.ReadLine()); //Ger subBalance ett värde
                        customerList[customerBalance - 1].balance += subBalance * -1; //Samma som ovan men adderar ett negativt tal
                        break;
                    case 7:
                        if (Directory.Exists(readFile) == false)
                        {
                            Directory.CreateDirectory(filename);
                        }
                        if (File.Exists(readFile) == false) //If file does not exist
                        {
                            var createdFile = File.Create(readFile); //Create file in selected directory
                            createdFile.Close();
                            string json = JsonConvert.SerializeObject(customerList); //Convert list to json format
                            File.WriteAllText(readFile, json); //Store list into into .txt file
                        }
                        notDone = false; //Ger notDone värdet false så loopen blir klar
                        break;
                }
                

            }
        }
    }
}
