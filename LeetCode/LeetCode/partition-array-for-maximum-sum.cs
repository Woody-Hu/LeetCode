using System;
using System.Linq;

namespace LeetCode
{
    public class partition_array_for_maximum_sum
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            var dp = new int[arr.Length];
            for (int i = 1; i <= k; i++)
            {
                dp[i - 1] = GetMaxValue(arr, 0, i - 1) * i; 
            }

            for (int i = k; i < arr.Length; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    dp[i] = Math.Max(dp[i - j] + GetMaxValue(arr, i - j + 1, i) * j, dp[i]);
                }
            }

            return dp[arr.Length - 1];
        }

        private int GetMaxValue(int[] arr, int start, int end)
        {
            int res = 0;
            for (int i = start; i <= end; i++)
            {
                res = Math.Max(res, arr[i]);
            }

            return res;
        }
    }
}
