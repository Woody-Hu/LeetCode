using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class partition_string_into_minimum_beautiful_substrings
	{
        public int MinimumBeautifulSubstrings(string s)
        {
            var n = s.Length;
            var set = new HashSet<string>();
            if (s[0] == '0')
            {
                return -1;
            }

            for (int i = 1; ; i*=5)
            {
                var t = Convert.ToString(i, 2);
                set.Add(t);
                if (t.Length >= n)
                {
                    break;
                }
            }

            var dp = new int[n];
            int INF = 0x3f3f3f3f;
            Array.Fill(dp, INF);
            dp[0] = 1;
            for (int i = 0; i < n; i++)
            {
                var t = string.Empty;
                for (int j = i; j >= 0; j--)
                {
                    t = s[j] + t;
                    if (set.Contains(t))
                    {
                        if (j == 0)
                        {
                            dp[i] = 1;
                        }
                        else
                        {
                            dp[i] = Math.Min(dp[i], dp[j - 1] + 1);
                        }
                    }
                }
            }

            return dp[n - 1] == INF ? -1 : dp[n - 1];
        }
    }
}

