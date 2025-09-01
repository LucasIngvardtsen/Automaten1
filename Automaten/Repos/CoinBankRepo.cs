using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repos
{
    public class CoinBankRepo : ICoinBank
    {
        private Dictionary<int, int> coins = new Dictionary<int, int>
        {
        { 1, 0 },
        { 2, 0 },
        { 5, 0 },
        { 10, 0 },
        { 20, 0 }
        };

        public void InsertCoin(int coin)
        {
            if (coins.ContainsKey(coin))
            {
                coins[coin]++;
            }
            else
            {
                throw new ArgumentException("Ugyldig mønt!");
            }
        }

        public int GetTotal()
        {
            int sum = 0;
            foreach (KeyValuePair<int, int> kv in coins)
            {
                sum += kv.Key * kv.Value;
            }
            return sum;
        }

        public void Reset()
        {
            List<int> keys = new List<int>(coins.Keys);
            foreach (int k in keys)
            {
                coins[k] = 0;
            }
        }

        public List<int> ReturnChange(int amount)
        {
            List<int> change = new List<int>();
            int[] denominations = new int[] { 20, 10, 5, 2, 1 };

            foreach (int coin in denominations)
            {
                while (amount >= coin)
                {
                    amount -= coin;
                    change.Add(coin);
                }
            }

            return change;
        }
    }
}
