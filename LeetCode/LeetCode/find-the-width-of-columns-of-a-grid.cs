using System;
namespace LeetCode
{
	public class find_the_width_of_columns_of_a_grid
	{
        public int[] FindColumnWidth(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var res = new int[m];
            var max = 0;
            for (int i = 0; i < m; i++)
            {
                max = 0;
                for (int j = 0; j < n; j++)
                {
                    max = Math.Max(grid[i][j].ToString().Length, max);
                }

                res[i] = max;
            }

            return res;
        }
    }
}

