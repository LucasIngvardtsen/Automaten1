using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Models
{
    public class Product
    {

        private static int _staticID = 1;
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
