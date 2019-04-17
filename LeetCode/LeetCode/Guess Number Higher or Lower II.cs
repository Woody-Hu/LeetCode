using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Guess_Number_Higher_or_Lower_II
    {
        public int GetMoneyAmount(int n)
        {
            int[,] dp = new int[n + 1, n + 1];
            for (int end = 1; end <= n; end++)
            {
                for (int start = end - 1; start >= 1; start--)
                {
                    int maxCost = -1, minMax = Int32.MaxValue;
                    for (int k = start + 1; k < end; k++)
                    {
                        maxCost = k + Math.Max(dp[start,k - 1], dp[k + 1,end]);  
                        minMax = Math.Min(maxCost, minMax);  
                    }
                    dp[start,end] = start == end - 1 ? start : minMax;
                }
            }
            return dp[1,n];
        }
    }
}
