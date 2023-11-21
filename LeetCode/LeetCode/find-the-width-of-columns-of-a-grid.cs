using System;
namespace LeetCode
{
	public class find_the_width_of_columns_of_a_grid
	{
        public int[] FindColumnWidth(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var res = new int[n];
            var max = 0;
            for (int i = 0; i < n; i++)
            {
                max = 0;
                for (int j = 0; j < m; j++)
                {
                    max = Math.Max(grid[j][i].ToString().Length, max);
                }

                res[i] = max;
            }

            return res;
        }
    }
}

