using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Models
{
    public class Payment
    {
        public int _balance;
        public Payment()
        {
            _balance = 0;
        }

        public void InsertCoin(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Beløbet skal være større end 0 kr.");
            _balance += amount;
        }

        public int GetBalance()
        {
            return _balance;
        }

        public void ResetBalance()
        {
            _balance = 0;
        }
    }
}
