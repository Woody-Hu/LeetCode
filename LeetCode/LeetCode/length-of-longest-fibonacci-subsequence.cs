using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class length_of_longest_fibonacci_subsequence
	{
        public int LenLongestFibSubseq(int[] arr)
        {
            var dic = new Dictionary<int, int>();
            var n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                dic.Add(arr[i], i);
            }

            var dp = new int[n, n];
            var res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0 && arr[j]*2 > arr[i]; j--)
                {
                    var exist = dic.GetValueOrDefault(arr[i] - arr[j], -1);
                    if (exist >= 0)
                    {
                        dp[j, i] = Math.Max(dp[exist, j] + 1, 3);
                    }

                    res = Math.Max(res, dp[j, i]);
                }
            }

            return res;
        }
    }
}

