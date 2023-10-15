using System;
namespace LeetCode
{
	public class divisible_and_non_divisible_sums_difference
	{
        public int DifferenceOfSums(int n, int m)
        {
            return n * (n + 1) / 2 - n / m * (n / m + 1) * m;
        }
    }
}

