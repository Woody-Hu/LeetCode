using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SurfaceAreaof3DShapes
    {
        public int SurfaceArea(int[][] grid)
        {
            int result = 0;
            int row = grid.Length;
            int col = grid[0].Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    if (grid[i][j] > 0)
                    {
                        result += 6 + (grid[i][j] - 1) * 4;
                    }
                    if (i - 1 >= 0)
                    {
                        int min = Math.Min(grid[i - 1][j], grid[i][j]);
                        result -= min;
                    }
                    if (j + 1 < col)
                    {
                        int min = Math.Min(grid[i][j + 1], grid[i][j]);
                        result -= min;
                    }
                    if (j - 1 >= 0)
                    {
                        int min = Math.Min(grid[i][j - 1], grid[i][j]);
                        result -= min;
                    }
                    if (i + 1 < row)
                    {
                        int min = Math.Min(grid[i + 1][j], grid[i][j]);
                        result -= min;
                    }
                }
            }

            return result;
        }
    }
}
