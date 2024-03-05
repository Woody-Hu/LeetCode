using System;
namespace LeetCode
{
	public class _i0mDW
	{
        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            var rows = grid.Length;
            var columns = grid[0].Length;
            var dp = new int[rows, columns];
            dp[0, 0] = grid[0][0];

            for (int i = 1; i < rows; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + grid[i][0];
            }

            for (int j = 1; j < columns; j++)
            {
                dp[0, j] = dp[0, j - 1] + grid[0][j];
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                }
            }


            return dp[rows - 1, columns - 1];

        }
    }
}

