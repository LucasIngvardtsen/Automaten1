using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repos
{
    public interface IPaymentRepo
    {

        void Add(TotalSum totalSum);
        void Remove(TotalSum totalSum);

    }
}
