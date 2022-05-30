using System;
namespace LeetCode
{
    public class knight_probability_in_chessboard
    {
        public double KnightProbability(int n, int k, int row, int column)
        {
            var directions = new (int, int)[] { (-1, -2), (-1, 2), (1, -2), (1, 2), (-2, 1), (-2, -1), (2, 1), (2, -1) };
            var dp = new double[n, n, k + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i, j, 0] = 1.0d;
                }
            }

            for (int i = 1; i <= k; i++)
            {
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        foreach (var item in directions)
                        {
                            var nextR = r + item.Item1;
                            var nextC = c + item.Item2;
                            if (nextR < 0 || nextC < 0 || nextR > n - 1 || nextC > n - 1)
                            {
                                continue;
                            }

                            dp[r, c, i] += dp[nextR, nextC, i - 1] / 8;
                        }
                    }
                }
            }

            return dp[row, column, k];
        }
    }
}
