using System;
namespace LeetCode
{
	public class cheapest_flights_within_k_stops
	{
		public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
		{
			var max = 10000 * 101 + 1;
			var dp = new int[k + 2, n];
			for (int i = 0; i < k + 2; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					dp[i, j] = max;
				}
			}

			dp[0, src] = 0;
            for (int i = 1; i <= k + 1; i++)
            {
                foreach (var item in flights)
                {
					var p1 = item[0];
					var p2 = item[1];
					var cost = item[2];
					dp[i, p2] = Math.Min(dp[i, p2], dp[i - 1, p1] + cost);
                }
            }

			var res = max;
            for (int i = 1; i <= k + 1; i++)
            {
				res = Math.Min(res, dp[i, dst]);
            }

            if (res == max)
            {
				return -1;
            }

			return res;
		}
	}
}

