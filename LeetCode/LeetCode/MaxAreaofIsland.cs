using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaxAreaofIsland
    {
        public int MaxAreaOfIsland(int[,] grid)
        {
            int res = 0;
            int[][] dir = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { -1, 0 }, new int[] { 1, 0 } };
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] == 1)
                        res = Math.Max(res, dfs(grid, i, j, dir));
                }
            }
            return res;
        }

        public int dfs(int[,] grid, int i, int j, int[][] dirs)
        {
            int res = 1;
            grid[i,j] = 0;
            foreach (var dir in dirs)
            {
                int x = i + dir[0];
                int y = j + dir[1];
                if (x < 0 || y < 0 || x >= grid.GetLength(0) || y >= grid.GetLength(1) || grid[x,y] == 0) continue;
                res += dfs(grid, x, y, dirs);
            }



            return res;
        }
    }
}
