using System;
namespace LeetCode
{
    public class maximum_sum_of_an_hourglass
    {
        public int MaxSum(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var res = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    var temp = grid[i][j] + grid[i][j + 1] + grid[i][j + 2]
                                 + grid[i + 1][j + 1] +
                     grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2];
                    res = Math.Max(res, temp);

                }
            }

            return res;
        }
    }
}

