using System;
using System.Linq;

namespace LeetCode
{
    public class sell_diminishing_valued_colored_balls
    {
        public int MaxProfit(int[] inventory, int orders)
        {
            Array.Sort(inventory, (a, b) => b - a);
            int idx = 0;
            long currPrice = inventory[0], nextPrice = 0, sell = 0, res = 0;

            while (orders > 0)
            {
                while (idx < inventory.Length && inventory[idx] == currPrice)
                    idx++;

                nextPrice = idx == inventory.Length ? 0 : inventory[idx];
                sell = Math.Min(orders, idx * (currPrice - nextPrice));
                long priceDiff = currPrice - nextPrice;
                int remainder = 0;
                if (orders < idx * (currPrice - nextPrice))
                {
                    priceDiff = orders / idx;
                    remainder = orders % idx;
                    nextPrice = currPrice - priceDiff;
                }

                res = (res + (currPrice + nextPrice + 1) * priceDiff / 2 * idx + nextPrice * remainder) % 1000000007;
                orders -= (int)sell;
                currPrice = nextPrice;
            }

            return (int)res;

        }
    }
}

