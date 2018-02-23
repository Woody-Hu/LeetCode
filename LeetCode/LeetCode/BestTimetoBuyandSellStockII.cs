using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            int returnValue = 0;

            int size = prices.Length;

            for (int i = 1; i < size; i++)
            {
                if (prices[i] > prices[i-1])
                {
                    returnValue += prices[i] - prices[i - 1];
                }
            }

            return returnValue;

        }
    }
}
