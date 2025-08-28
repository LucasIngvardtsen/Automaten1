using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repos
{
    public interface IProduct
    {

        void Add(Product product);
        void Remove(Product product);
    }
}
