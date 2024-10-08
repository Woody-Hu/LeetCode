using System;

namespace LeetCode;

public class time_needed_to_buy_tickets
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int n = tickets.Length;
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            if (i <= k)
            {
                res += Math.Min(tickets[i], tickets[k]);
            }
            else
            {
                res += Math.Min(tickets[i], tickets[k] - 1);
            }
        }

        return res;
    }
}