using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class final_prices_with_a_special_discount_in_a_shop
	{
		public int[] FinalPrices(int[] prices)
		{
			var stack = new Stack<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                while (stack.Any() && prices[i] <= prices[stack.Peek()] )
                {
					var j = stack.Pop();
					prices[j] = prices[j] - prices[i];
                }

				stack.Push(i);
            }

			return prices;
		}
	}
}

