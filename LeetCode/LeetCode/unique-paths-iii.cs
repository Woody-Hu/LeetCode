using System;
namespace LeetCode
{
	public class unique_paths_iii
	{
        private readonly int[][] _dirs = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };

        public int UniquePathsIII(int[][] grid)
        {
            var r = grid.Length;
            var c = grid[0].Length;
            int si = 0, sj = 0, n = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        n++;
                    }
                    else if (grid[i][j] == 1)
                    {
                        n++;
                        si = i;
                        sj = j;
                    }
                }
            }

            return DFS(grid, si, sj, n);
        }

        private int DFS(int[][] grid, int i, int j, int n)
        {
            if (grid[i][j] == 2)
            {
                return n == 0 ? 1 : 0;
            }

            int r = grid.Length, c = grid[0].Length;
            int t = grid[i][j];
            grid[i][j] = -1;
            int res = 0;
            foreach (int[] dir in _dirs)
            {
                int ni = i + dir[0], nj = j + dir[1];
                if (ni >= 0 && ni < r && nj >= 0 && nj < c && (grid[ni][nj] == 0 || grid[ni][nj] == 2))
                {
                    res += DFS(grid, ni, nj, n - 1);
                }
            }

            grid[i][j] = t;
            return res;
        }
    }
}

