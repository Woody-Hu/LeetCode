using System;
namespace LeetCode
{
	public class buy_two_chocolates
	{
        public int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            if (prices[0] + prices[1] > money)
            {
                return money;
            }

            return money - (prices[0] + prices[1]);
        }
    }
}

