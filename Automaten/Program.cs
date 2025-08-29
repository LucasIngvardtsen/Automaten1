using Automaten.Models;

namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Product soda1 = new Product("Coca Cola", 20);
            Product soda2 = new Product("Coca Cola Zero", 20);
            Product soda3 = new Product("Fanta", 20);
            Product soda4 = new Product("Sprite", 20);
            Product soda5 = new Product("Fanta Exotic", 20);

            Console.WriteLine("Velkommen til Automaten! Indtast venligst ID på det ønskede produkt.");
            string input = Console.ReadLine();

            Queue<string> colaQueue = new Queue<string>();
            colaQueue.Enqueue("Coca");
            colaQueue.Enqueue("Cola");
            colaQueue.Enqueue("Cola");
            colaQueue.Enqueue("Cola");
            colaQueue.Enqueue("Cola");

            Queue<string> colazeroQueue = new Queue<string>();
            colazeroQueue.Enqueue("Cola Zero");
            colazeroQueue.Enqueue("Cola Zero");
            colazeroQueue.Enqueue("Cola Zero");
            colazeroQueue.Enqueue("Cola Zero");
            colazeroQueue.Enqueue("Cola Zero");

            Queue<string> fantaQueue = new Queue<string>();
            fantaQueue.Enqueue("Fanta");
            fantaQueue.Enqueue("Fanta");
            fantaQueue.Enqueue("Fanta");
            fantaQueue.Enqueue("Fanta");
            fantaQueue.Enqueue("Fanta");

            Queue<string> spriteQueue = new Queue<string>();
            spriteQueue.Enqueue("Sprite");
            spriteQueue.Enqueue("Sprite");
            spriteQueue.Enqueue("Sprite");
            spriteQueue.Enqueue("Sprite");
            spriteQueue.Enqueue("Sprite");

            //Queue<string> fantaexoticQueue = new Queue<string>();
            //fantaexoticQueue.Enqueue("Fanta Exotic");
            //fantaexoticQueue.Enqueue("Fanta Exotic");
            //fantaexoticQueue.Enqueue("Fanta Exotic");
            //fantaexoticQueue.Enqueue("Fanta Exotic");
            //fantaexoticQueue.Enqueue("Fanta Exotic");


            switch (input)
            {
                case "1":
                    colaQueue.Dequeue();
                    Console.WriteLine("Der udleveres nu en Cola");
                    break;
                case "2":
                    colazeroQueue.Dequeue();
                    Console.WriteLine("Der udleveres nu en Cola Zero");
                    break;
                case "3":
                    fantaQueue.Dequeue();
                    Console.WriteLine("Der udleveres nu en Fanta");
                    break;
                case "4":
                    spriteQueue.Dequeue();
                    Console.WriteLine("Der udleveres nu en Sprite");
                    break;
                case "5":
                    fantaexoticQueue.Dequeue();
                    Console.WriteLine("Der udleveres nu en Fanta Exotic");
                    break;
                default:
                    Console.WriteLine("Produkt ikke fundet.");
                    break;

            }

        }
    }
}
