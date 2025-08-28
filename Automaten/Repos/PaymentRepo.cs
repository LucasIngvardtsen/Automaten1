using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;

namespace Automaten.Repos
{
    public class PaymentRepo : IPaymentRepo
    {
        private List<Payment> _payment = new List<Payment>();
        public void Add(Payment payment)
        {
            _payment.Add(payment);
        }

        public void Remove(Payment payment)
        {
            _payment.Remove(payment);
        }
    }
}
