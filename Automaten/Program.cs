using Automaten.Models;
using Automaten.Services;

namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachineService service = new VendingMachineService();

            Product cola = new Product("Cola", 15);

            // Keep track of inserted coins
            List<CoinBank> userCoins = new List<CoinBank>();
            int totalInserted = 0;

            Console.WriteLine($"The price of {cola.Name} is {cola.Price} kr.");

            while (totalInserted < cola.Price)
            {
                Console.Write("Insert coin (5, 10, 20): ");
                string input = Console.ReadLine();
                int coinValue;

                if (int.TryParse(input, out coinValue) && (coinValue == 5 || coinValue == 10 || coinValue == 20))
                {
                    userCoins.Add(new CoinBank(coinValue));
                    totalInserted += coinValue;
                    Console.WriteLine($"Total inserted: {totalInserted} kr");
                }
                else
                {
                    Console.WriteLine("Invalid coin. Try 5, 10, or 20 kr.");
                }
            }

            Console.WriteLine($"Payment complete! You can buy the {cola.Name}.");
            int change = totalInserted - cola.Price;

            if (change > 0)
                Console.WriteLine($"Your change: {change} kr");

            //Console.WriteLine("Indkast venligst pengene til det ønskede produkt. Automaten tager kun imod 5, 10 og 20 kr.");
            //string coininsert = Console.ReadLine();

            //switch (coininsert)
            //{
            //    case "5":
            //        Console.WriteLine("Der er nu +5 kr i maskinen");
            //        break;
            //    case "10":
            //        Console.WriteLine("Der er nu +10 kr i maskinen");
            //        break;
            //    case "20":
            //        Console.WriteLine("Der er nu +20 kr i maskinen");
            //        break;
            //    default:
            //        Console.WriteLine("Ugyldigt beløb indkastet.");
            //        break;

            //}

            //Console.WriteLine("Indsæt flere penge? eller skriv færdig");
            //string coininsert2 = Console.ReadLine();

            //switch (coininsert2)
            //{
            //    case "5":
            //        Console.WriteLine("Der er nu +5 kr i maskinen");
            //        break;
            //    case "10":
            //        Console.WriteLine("Der er nu +10 kr i maskinen");
            //        break;
            //    case "20":
            //        Console.WriteLine("Der er nu +20 kr i maskinen");
            //        break;
            //    case "færdig":
            //        Console.WriteLine("Du har tastet færdig");
            //        break;
            //    default:
            //        Console.WriteLine("Ugyldigt beløb indkastet.");
            //        break;

            //}


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
