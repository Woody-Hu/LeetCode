using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode
{
    class Best_Time_to_Buy_and_Sell_Stock_with_Cooldown
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;

            var b0 = -prices[0];
            var b1 = b0;

            var s2 = 0;
            var s1 = 0;
            var s0 = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                b0 = Math.Max(b1, s2 - prices[i]);
                s0 = Math.Max(s1, b1 + prices[i]);

                b1 = b0;
                s2 = s1;
                s1 = s0;
            }

            return s0;
        }
    }
}
