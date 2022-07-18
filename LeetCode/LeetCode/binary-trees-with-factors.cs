using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class binary_trees_with_factors
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            var mod = 1_000_000_007;
            var n = arr.Length;
            var dic = new Dictionary<int, int>();
            Array.Sort(arr);
            for (int i = 0; i < n; i++)
            {
                dic[arr[i]] = i;
            }

            var dp = new long[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] % arr[j] == 0)
                    {
                        var target = arr[i]/arr[j];
                        if (dic.TryGetValue(target, out var targetIndex))
                        {
                            dp[i] = (dp[i] + dp[j] * dp[targetIndex]) % mod;
                        }
                    }
                }
            }

            long res = 0;
            foreach (var item in dp)
            {
                res += item;
            }

            return (int)(res % mod);
        }
    }
}
