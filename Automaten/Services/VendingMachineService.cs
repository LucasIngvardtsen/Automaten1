using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;
using Automaten.Repos;

namespace Automaten.Services
{
    public class VendingMachineService
    {
        private ProductRepo repo = new ProductRepo();
        //private CoinBankRepo coinrepo = new CoinBankRepo();

        public Product Purchase(string name)
        {
            return repo.BuyProduct(name);
        }

        public int CheckStock(string name)
        {
            return repo.GetStock(name);
        }
    }
}
