using System;
namespace LeetCode
{
	public class determine_the_minimum_sum_of_a_k_avoiding_array
	{
        public int MinimumSum(int n, int k)
        {
            var m = Math.Min(k / 2, n);
            return (m * (m + 1) + (k * 2 + n - m - 1) * (n - m)) / 2;
        }
    }
}

