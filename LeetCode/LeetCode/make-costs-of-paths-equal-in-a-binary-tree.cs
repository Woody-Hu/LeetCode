using System;
namespace LeetCode
{
	public class make_costs_of_paths_equal_in_a_binary_tree
	{
        public int MinIncrements(int n, int[] cost)
        {
            var res = 0;
            for (int i = n/2; i > 0; i--)
            {
                res += Math.Abs(cost[i * 2 - 1] - cost[i * 2]);
                cost[i - 1] = Math.Max(cost[i * 2 - 1], cost[i * 2]);
            }

            return res;
        }
    }
}

