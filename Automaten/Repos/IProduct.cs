using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;

namespace Automaten.Repos
{
    public interface IProductRepo
    {
        Product BuyProduct(string name); // Metode til at købe et produkt baseret på navn
        int GetStock(string name);        // Metode til at få lagerstatus for et produkt
    }
}
