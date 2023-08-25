using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class largest_plus_sign
	{
        public int OrderOfLargestPlusSign(int n, int[][] mines)
        {
            var dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                var temp = new int[n];
                Array.Fill(temp, n);
                dp[i] = temp;
            }

            var set = new HashSet<int>();
            foreach (var item in mines)
            {
                set.Add(item[0] * n + item[1]);
            }

            var res = 0;
            for (int i = 0; i < n; i++)
            {
                var count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (set.Contains(i * n + j))
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }

                    dp[i][j] = Math.Min(dp[i][j], count);
                }

                count = 0;
                for (int j = n - 1; j >= 0; j--)
                {
                    if (set.Contains(i * n + j))
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }

                    dp[i][j] = Math.Min(dp[i][j], count);
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                var count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (set.Contains(j * n + i))
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }

                    dp[j][i] = Math.Min(dp[j][i], count);
                }

                count = 0;
                for (int j = n - 1; j >= 0; j--)
                {
                    if (set.Contains(j * n + i))
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }

                    dp[j][i] = Math.Min(dp[j][i], count);
                    res = Math.Max(res, dp[j][i]);
                }
            }

            return res;
        }
    }
}

