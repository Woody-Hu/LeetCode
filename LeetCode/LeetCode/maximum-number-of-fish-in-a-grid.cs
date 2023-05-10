using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class maximum_number_of_fish_in_a_grid
	{
        private static IEnumerable<int[]> _directions = new List<int[]>() { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };

        public int FindMaxFish(int[][] grid)
        {
            var res = 0;
            var m = grid.Length;
            var n = grid[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res = Math.Max(res, DFS(grid, i, j));
                }
            }

            return res;
        }

        private int DFS(int[][] grid, int x, int y)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            if (x < 0 || x >= m || y < 0 || y >= n || grid[x][y] == 0)
            {
                return 0;
            }

            var res = grid[x][y];
            grid[x][y] = 0;
            foreach (var item in _directions)
            {
                res += DFS(grid, x + item[0], y + item[1]);
            }

            return res;
        }
    }
}

