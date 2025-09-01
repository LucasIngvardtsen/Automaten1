using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Models;

namespace Automaten.Repos
{
    public class CoinBankRepo
    {

        public Stack<CoinBank> Femmer = new Stack<CoinBank>(); // 5 kr
        public Stack<CoinBank> Tier = new Stack<CoinBank>();   // 10 kr
        public Stack<CoinBank> Tyver = new Stack<CoinBank>();  // 20 kr

        public CoinRepo()
        {
            // Fill each stack with initial coins
            for (int i = 0; i < 10; i++) Femmer.Push(new CoinBank(5));
            for (int i = 0; i < 5; i++) Tier.Push(new CoinBank(10));
            for (int i = 0; i < 2; i++) Tyver.Push(new CoinBank(20));
        }

        // Take a coin from the correct stack
        public CoinBank TakeCoin(int value)
        {
            if (value == 5 && Femmer.Count > 0) return Femmer.Pop();
            if (value == 10 && Tier.Count > 0) return Tier.Pop();
            if (value == 20 && Tyver.Count > 0) return Tyver.Pop();

            return null; // No coin of that value left
        }

        // Check stock of a coin type
        public int GetStock(int value)
        {
            if (value == 5) return Femmer.Count;
            if (value == 10) return Tier.Count;
            if (value == 20) return Tyver.Count;
            return 0;
        }
    }

}
}
