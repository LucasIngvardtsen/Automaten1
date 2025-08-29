using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Automaten.Models;

namespace Automaten.Repos
{
    public class ProductRepo
    {
        public Queue<Product> ColaQueue = new Queue<Product>();
        public Queue<Product> FantaQueue = new Queue<Product>();
        public Queue<Product> SkumbananQueue = new Queue<Product>();

        public ProductRepo()
        {
            // Fyld køerne
            for (int i = 0; i < 5; i++) ColaQueue.Enqueue(new Product("Cola", 15));
            for (int i = 0; i < 3; i++) FantaQueue.Enqueue(new Product("Fanta", 14));
            for (int i = 0; i < 7; i++) SkumbananQueue.Enqueue(new Product("Skumbanan", 10));
        }

        public Product BuyProduct(string name)
        {
            if (name == "Cola" && ColaQueue.Count > 0)
                return ColaQueue.Dequeue();
            else if (name == "Fanta" && FantaQueue.Count > 0)
                return FantaQueue.Dequeue();
            else if (name == "Skumbanan" && SkumbananQueue.Count > 0)
                return SkumbananQueue.Dequeue();
            else
                return null; // Udsolgt eller findes ikke
        }

        public int GetStock(string name)
        {
            if (name == "Cola") return ColaQueue.Count;
            if (name == "Fanta") return FantaQueue.Count;
            if (name == "Skumbanan") return SkumbananQueue.Count;
            return 0;
        }
    }
}

