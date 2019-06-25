using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Ones_and_Zeroes
    {
        public int FindMaxForm(string[] strs, int m, int n)
        {
            var dp = new int[m + 1, n + 1];
            foreach (var s in strs)
            {
                int zero = 0, one = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '0')
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }
                for (int i = m; i > zero - 1; i--)
                {
                    for (int j = n; j > one - 1; j--)
                    {
                        dp[i, j] = Math.Max(dp[i, j], dp[i - zero, j - one] + 1);
                    }
                }
            }
            return dp[m, n];
        }
    }
}
