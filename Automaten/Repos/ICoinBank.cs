using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repos
{
    public interface ICoinBank
    {
        void InsertCoin(int coin);              // Indsæt en mønt i banken
        int GetTotal();                         // Beregn det samlede beløb i banken
        void Reset();                           // Nulstil møntbanken
        List<int> ReturnChange(int amount);     // Returner byttepenge
        int TakeCoin(int value);                // Tag en mønt af den angivne værdi
        int GetStock(int value);                // Tjek lagerstatus for en mønttype
    }
}

