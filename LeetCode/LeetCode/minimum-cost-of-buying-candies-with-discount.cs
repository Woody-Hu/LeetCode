using System;

namespace LeetCode;

public class minimum_cost_of_buying_candies_with_discount
{
    public int MinimumCost(int[] cost)
    {
        var res = 0;
        Array.Sort(cost);
        int n = cost.Length;
        for (int i = 1; i <= n; i++) {
            if (i % 3 != 0) {
                res += cost[n - i];
            }
        }
        
        return res;
    }
}