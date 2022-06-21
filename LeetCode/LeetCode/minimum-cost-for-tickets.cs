using System;
namespace LeetCode
{
    public class minimum_cost_for_tickets
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            var len = days.Length;
            var maxDay = days[days.Length - 1];
            var minDay = days[0];
            var dp = new int[maxDay + 31];
            for (int d = maxDay, i = len - 1; d >= minDay; d--)
            {
                if (d == days[i])
                {
                    dp[d] = Math.Min(dp[d + 1] + costs[0], dp[d + 7] + costs[1]);
                    dp[d] = Math.Min(dp[d], dp[d + 30] + costs[2]);
                    i--;
                }
                else
                {
                    dp[d] = dp[d + 1];
                }
            }

            return dp[minDay];
        }
    }
}
