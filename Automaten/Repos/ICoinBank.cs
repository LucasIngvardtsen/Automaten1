using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repos
{
    public interface ICoinBank
    {
        void InsertCoin(int coin);
        int GetTotal();
        void Reset();
        List<int> ReturnChange(int amount);
    }
}
