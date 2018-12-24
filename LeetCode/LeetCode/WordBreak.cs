using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class WordBreak
    {
        public bool WordBreakMethod(string s, IList<string> wordDict)
        {
            var n = s.Length;

            var dp = new bool[n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    var sub = s.Substring(j, i + 1 - j);

                    if (wordDict.Contains(sub) && (j == 0 || dp[j - 1]))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n - 1];
        }
    }
}
