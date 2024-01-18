using System;
namespace LeetCode
{
	public class distribute_candies_among_children_i
	{
        public int DistributeCandies(int n, int limit)
        {
            return C(n + 2) - 3 * C(n - limit + 1) + 3 * C(n - 2 * limit) - C(n - 3 * limit - 1);
        }

        private int C(int n)
        {
            return n > 1 ? n * (n - 1) / 2 : 0;
        }
    }
}

