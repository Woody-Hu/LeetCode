using System;
namespace LeetCode
{
    public class out_of_boundary_paths
    {
        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            var dp = new int[maxMove + 1, m, n];
            dp[0, startRow, startColumn] = 1;
            var directions = new (int, int)[] { (0, 1), (1, 0), (0, -1), (-1, 0) };
            var mod = 1000000007;
            var res = 0;
            for (int k = 0; k < maxMove; k++)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        var currentCount = dp[k, i, j];
                        if (currentCount > 0)
                        {
                            foreach (var item in directions)
                            {
                                var nextI = i + item.Item1;
                                var nextJ = j + item.Item2;
                                if (nextI >= 0 && nextI < m && nextJ >= 0 && nextJ < n)
                                {
                                    dp[k + 1, nextI, nextJ] = (dp[k + 1, nextI, nextJ] + currentCount) % mod;
                                }
                                else
                                {
                                    res = (res + currentCount) % mod;
                                }
                            }
                        }
                    }
                }
            }

            return res;
        }
    }
}
