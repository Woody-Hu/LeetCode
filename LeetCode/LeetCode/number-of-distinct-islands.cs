using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class number_of_distinct_islands
	{
		public int NumDistinctIslands(int[][] grid)
		{
			var set = new HashSet<string>();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
						var stringBuilder = new StringBuilder();
						Visit(grid, i, j, stringBuilder);
						set.Add(stringBuilder.ToString());
                    }
                }
            }

			return set.Count;
		}


		private void Visit(int[][] grid, int i, int j, StringBuilder stringBuilder)
        {
            if (i <  0 || i >= grid.GetLength(0) || j < 0 || j >= grid[0].Length || grid[i][j] != 1)
            {
				return;
            }

			grid[i][j] = 0;
			Visit(grid, i - 1, j, stringBuilder.Append("l"));
			Visit(grid, i, j + 1, stringBuilder.Append("u"));
			Visit(grid, i+ 1, j, stringBuilder.Append("r"));
			Visit(grid, i , j - 1, stringBuilder.Append("d"));
		}
	}
}

