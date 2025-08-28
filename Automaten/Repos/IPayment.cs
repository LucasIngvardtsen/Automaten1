using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repos
{
    public interface IPayment
    {

        void Add(Balance balance);
        void Remove(Balance balance);

        //List<fives> _fives;
        //List<tens> 
        //List<twenties> 

        //void Add List<fives>
        //void Remove List<fives>
        //void Add List<tens>
        //void Remove List<tens>
        //void Add List<twenties>
        //void Remove List<twenties>
    }
}
