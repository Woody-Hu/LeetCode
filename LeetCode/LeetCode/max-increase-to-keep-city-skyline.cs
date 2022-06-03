using System;
namespace LeetCode
{
	public class max_increase_to_keep_city_skyline
	{
		public int MaxIncreaseKeepingSkyline(int[][] grid)
		{
			var n = grid.Length;
			var row = new int[n];
			var column = new int[n];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
					row[i] = Math.Max(row[i], grid[i][j]);
					column[j] = Math.Max(column[j], grid[i][j]);
                }
            }

			var res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    res += Math.Min(row[i], column[j]) - grid[i][j];
                }
            }

            return res;
		}
	}
}

