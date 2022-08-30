using System;
namespace LeetCode
{
    public class minimum_path_cost_in_a_grid
    {
        public int MinPathCost(int[][] grid, int[][] moveCost)
        {
            var rows = grid.Length;
            var columns = grid[0].Length;
            var dp = new int[rows, columns];
            for (int i = 0; i < columns; i++)
            {
                dp[0, i] = grid[0][i];
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i - 1, k] + grid[i][j] + moveCost[grid[i - 1][k]][j]);
                    }
                }
            }

            var res = int.MaxValue;
            for (int i = 0; i < columns; i++)
            {
                res = Math.Min(res, dp[rows - 1, i]);
            }

            return res;
        }
    }
}
