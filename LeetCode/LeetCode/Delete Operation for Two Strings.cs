using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Delete_Operation_for_Two_Strings
    {
        public int MinDistance(string word1, string word2)
        {
            var length1 = word1.Length;
            var length2 = word2.Length;

            var dp = new int[length1 + 1, length2 + 1];
            for (int i = 1; i <= length1; i++)
            {
                for (int j = 1; j <= length2; j++)
                {
                    if (word1[i-1] == word2[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i,j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return length1 + length2 - 2* dp[length1, length2];
        }
    }
}
