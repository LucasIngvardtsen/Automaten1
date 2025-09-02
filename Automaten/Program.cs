using Automaten.Models;
using Automaten.Services;

namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachineService service = new VendingMachineService(); // Opret produkter

            Product cola = new Product { Name = "Cola", Price = 15 };
            Product fanta = new Product { Name = "Fanta", Price = 14 };
            Product skumbanan = new Product { Name = "Skumbanan", Price = 10 }; // Vis produkter

            Console.WriteLine("Vælg et produkt:");
            Console.WriteLine($"{cola.Name} - {cola.Price} kr");
            Console.WriteLine($"{fanta.Name} - {fanta.Price} kr");
            Console.WriteLine($"{skumbanan.Name} - {skumbanan.Price} kr"); // Keep track of inserted coins

            int totalInserted = 0;

            while (true)
            {
                Console.Write("Indsæt mønt (5, 10, 20), skriv 'køb' for at vælge et produkt eller '9' for at annullere: ");
                string input = Console.ReadLine();
                int coinValue;

                if (input.ToLower() == "køb")
                {
                    Console.Write("Indtast produktnavn (Cola, Fanta, Skumbanan): ");
                    string productName = Console.ReadLine();

                    Product selectedProduct = null;

                    if (productName.Equals("Cola", StringComparison.OrdinalIgnoreCase))
                        selectedProduct = cola;
                    else if (productName.Equals("Fanta", StringComparison.OrdinalIgnoreCase))
                        selectedProduct = fanta;
                    else if (productName.Equals("Skumbanan", StringComparison.OrdinalIgnoreCase))
                        selectedProduct = skumbanan; // Tjek om produktet er valgt og om der er tilstrækkelige penge

                    if (selectedProduct != null)
                    {
                        if (totalInserted >= selectedProduct.Price)
                        {
                            int change = totalInserted - selectedProduct.Price;
                            Console.WriteLine($"Du har købt en {selectedProduct.Name} til {selectedProduct.Price} kr.");

                            if (change > 0)
                                Console.WriteLine($"Dine byttepenge: {change} kr");
                            break; // Afslut programmet efter køb
                        }
                        else
                        {
                            Console.WriteLine("Ikke nok penge til at købe produktet. Indsæt flere mønter.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt produkt. Prøv igen.");
                    }
                }
                else if (input == "9")
                {
                    Console.WriteLine($"Ordren er annulleret. Du får dine penge tilbage: {totalInserted} kr.");
                    totalInserted = 0; // Nulstil indsat beløb
                }
                else if (int.TryParse(input, out coinValue) && (coinValue == 5 || coinValue == 10 || coinValue == 20))
                { // Indsæt mønt
                    service.InsertCoin(coinValue);
                    totalInserted += coinValue;
                    Console.WriteLine($"Total indsat: {totalInserted} kr");
                }
                else
                {
                    Console.WriteLine("Ugyldig mønt. Prøv 5, 10 eller 20 kr.");
                }
            }
        }
    }
}
