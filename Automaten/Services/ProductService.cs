using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;
using Automaten.Repos;

namespace Automaten.Services
{
    public class ProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        

        public void RestockProduct(string name, int quantity) 
        { 
            List<Product> products = _productRepo.GetAllProducts(); 
            Product product = products.FirstOrDefault(p => p.Name == name); 
            if (product != null) 
            { 
                product.Stock += quantity; _productRepo.SaveProducts(products); 
            } 
        }
        public List<Product> LoadProducts() 
        { 
            return _productRepo.GetAllProducts(); 
        }








    }
}
