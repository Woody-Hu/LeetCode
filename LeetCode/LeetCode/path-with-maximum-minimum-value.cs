using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class path_with_maximum_minimum_value
	{
		public int MaximumMinimumPath(int[][] grid)
		{
			var directions = new int[][] { new int[] { 0, 1 }, new int[] { -1, 0 }, new int[] { 0, -1 }, new int[] { 1, 0 } };
			var n = grid.Length;
			var m = grid[0].Length;
			var start = grid[0][0];
			var end = grid[n - 1][m - 1];
			var left = 0;
			var right = Math.Min(start, end);
			var res = -1;
            while (left <= right)
            {
				var mid = (left + right) / 2;
				if (Visit(grid, 0, 0, n, m, directions, new HashSet<string>(), mid))
				{
					res = Math.Max(res, mid);
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
            }

			return res;
		}

		private bool Visit(int[][] grid, int i, int j, int n, int m, int[][] directions, HashSet<string> visted, int target)
		{
            if (i == n -1 && j == m -1)
            {
				return true;
            }

			var key = $"{i},{j}";
			visted.Add(key);
            foreach (var item in directions)
            {
				var x = i + item[0];
				var y = j + item[1];
				var newKey = $"{x},{y}";
                if (x >=  0 && x < n && y >=0 && y < m && !visted.Contains(newKey) && grid[x][y] >= target)
                {
                    if (Visit(grid, x, y, n, m, directions, visted, target))
                    {
						return true;
                    }
                }
            }

			return false;
		}

	
	}
}

