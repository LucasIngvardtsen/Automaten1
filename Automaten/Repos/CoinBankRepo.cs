using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;

namespace Automaten.Repos
{
    public class CoinBankRepo : ICoinBank
    {
        private Stack<int> Femmer = new Stack<int>(); // 5 kr
        private Stack<int> Tier = new Stack<int>();   // 10 kr
        private Stack<int> Tyver = new Stack<int>();  // 20 kr

        public CoinBankRepo()
        {
            // Fyld hver stak med initiale mønter
            for (int i = 0; i < 10; i++) Femmer.Push(5);
            for (int i = 0; i < 5; i++) Tier.Push(10);
            for (int i = 0; i < 2; i++) Tyver.Push(20);
        }

        // Indsæt en mønt i banken
        public void InsertCoin(int coin)
        {
            // Logik til at tilføje mønter til banken, hvis det er nødvendigt
        }

        // Tag en mønt af den angivne værdi
        public int TakeCoin(int value)
        {
            if (value == 5 && Femmer.Count > 0) return Femmer.Pop();
            if (value == 10 && Tier.Count > 0) return Tier.Pop();
            if (value == 20 && Tyver.Count > 0) return Tyver.Pop();
            return 0; // Ingen mønt af den værdi tilbage
        }

        // Tjek lagerstatus for en mønttype
        public int GetStock(int value)
        {
            if (value == 5) return Femmer.Count;
            if (value == 10) return Tier.Count;
            if (value == 20) return Tyver.Count;
            return 0;
        }

        // Beregn det samlede beløb i banken
        public int GetTotal()
        {
            return (Femmer.Count * 5) + (Tier.Count * 10) + (Tyver.Count * 20);
        }

        // Nulstil møntbanken
        public void Reset()
        {
            Femmer.Clear();
            Tier.Clear();
            Tyver.Clear();
        }

        // Returner byttepenge
        public List<int> ReturnChange(int amount)
        {
            List<int> change = new List<int>();
            while (amount > 0)
            {
                if (amount >= 20 && Tyver.Count > 0)
                {
                    change.Add(Tyver.Pop());
                    amount -= 20;
                }
                else if (amount >= 10 && Tier.Count > 0)
                {
                    change.Add(Tier.Pop());
                    amount -= 10;
                }
                else if (amount >= 5 && Femmer.Count > 0)
                {
                    change.Add(Femmer.Pop());
                    amount -= 5;
                }
                else
                {
                    break; // Ikke nok mønter til at give bytte
                }
            }
            return change;
        }
    }

}

