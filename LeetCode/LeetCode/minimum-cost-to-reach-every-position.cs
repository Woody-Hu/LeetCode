using System;

namespace LeetCode;

public class minimum_cost_to_reach_every_position
{
    public int[] MinCosts(int[] cost) {
        for (int i = 1; i < cost.Length; i++)
        {
            cost[i] = Math.Min(cost[i], cost[i - 1]);
        }

        return cost;

    }
}