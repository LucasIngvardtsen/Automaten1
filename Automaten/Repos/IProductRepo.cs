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

        List<Product> GetAllProducts();
        void SaveProducts(List<Product> products);
            
        
    }
}
