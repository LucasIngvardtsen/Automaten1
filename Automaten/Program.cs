using Automaten.Models;
using Automaten.Services;

namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachineService service = new VendingMachineService();

            while (true)
            {
                Console.Write("Vælg et produkt (Cola/Fanta/Skumbanan) eller 'exit': ");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "exit")
                    break;

                Product bought = service.Purchase(choice);

                if (bought != null)
                {
                    Console.WriteLine("Du har købt en " + bought.Name + " til " + bought.Price + " kr.");
                    int stockLeft = service.CheckStock(choice);
                    Console.WriteLine("Der er nu " + stockLeft + " tilbage på lager.");
                }
                else
                {
                    Console.WriteLine("Udsolgt eller ugyldigt valg!");
                }
            }

        }
    }
}
