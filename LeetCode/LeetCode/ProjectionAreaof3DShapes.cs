using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ProjectionAreaof3DShapes
    {
        public int ProjectionArea(int[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0) return 0;
            int[] row = new int[grid.Length], col = new int[grid[0].Length];
            int res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    res += grid[i][j] != 0 ? 1 : 0;
                    col[j] = Math.Max(col[j], grid[i][j]);
                    row[i] = Math.Max(row[i], grid[i][j]);
                }
            }

            foreach (var oneValue in row)
            {
                res += oneValue;
            }

            foreach (var oneValue in col)
            {
                res += oneValue;
            }

            return res;

        }
    }
}
