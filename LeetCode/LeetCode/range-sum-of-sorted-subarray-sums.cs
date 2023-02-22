using System;
using System.Reflection;

namespace LeetCode
{
	public class range_sum_of_sorted_subarray_sums
	{
        public int RangeSum(int[] nums, int n, int left, int right)
        {
            const int modulo = 1000000007;
            var sumLength = n * (n + 1) / 2;
            var sums = new int[sumLength];
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += nums[j];
                    sums[index++] = sum;
                }
            }

            Array.Sort(sums);
            var ans = 0;
            for (int i = left - 1; i < right; i++)
            {
                ans = (ans + sums[i]) % modulo;
            }

            return ans;
        }
    }
}

