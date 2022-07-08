using System;
namespace LeetCode
{
    public class count_square_submatrices_with_all_ones
    {
        public int CountSquares(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var dp = new int[n, m];
            var res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        if (i == 0 || j == 0)
                        {
                            res++;
                            dp[i, j] = 1;
                        }
                        else
                        {
                            dp[i, j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]) + 1;
                            res += dp[i, j];
                        }
                    }
                }
            }

            return res;
        }
    }
}
