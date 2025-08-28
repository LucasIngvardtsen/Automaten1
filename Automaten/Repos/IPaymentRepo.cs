using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;

namespace Automaten.Repos
{
    public interface IPaymentRepo
    {
        void Add(Payment payment);
        void Remove(Payment payment);


    }
}
