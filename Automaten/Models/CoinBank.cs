using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Automaten.Models
{
    public class CoinBank
    {

        private int _value;

        public int Value { get => _value; set => this._value = value; }

        public CoinBank(int value)
        {
            Value = value;
        }

    }
}
