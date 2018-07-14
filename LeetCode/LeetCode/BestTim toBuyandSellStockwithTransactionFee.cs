using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BestTim_toBuyandSellStockwithTransactionFee
    {
        public int MaxProfit(int[] prices, int fee)
        {

            int buy, tempBuy, sell, tempSell;

            buy = tempBuy = -prices[0];

            sell = tempSell = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                tempBuy = buy;

                buy = Math.Max(tempBuy, sell - prices[i]);

                sell = Math.Max(tempSell, tempBuy + prices[i] - fee);
                tempSell = sell;
            }

            return sell;
        }
    }
}
