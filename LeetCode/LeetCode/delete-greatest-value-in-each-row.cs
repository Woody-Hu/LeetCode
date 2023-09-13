using System;
namespace LeetCode
{
	public class delete_greatest_value_in_each_row
	{
        public int DeleteGreatestValue(int[][] grid)
        {
            var res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                Array.Sort(grid[i]);
            }

            for (int j = 0; j < grid[0].Length; j++)
            {
                var max = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    max = Math.Max(max, grid[i][j]);
                }

                res += max;
            }

            return res;
        }
    }
}

