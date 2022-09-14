using System;
namespace LeetCode
{
    public class number_of_closed_islands
    {
        public int ClosedIsland(int[][] grid)
        {
            var res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        var val = 1;
                        Visit(grid, i, j, ref val, ref res);
                        res += val;
                    }
                }
            }

            return res;
        }

        private void Visit(int[][] grid, int i, int j, ref int val, ref int res)
        {
            if (i < 0 || i == grid.Length || j < 0 || j == grid[0].Length)
            {
                val = 0;
                return;
            }

            if (grid[i][j] != 0)
            {
                return;
            }

            grid[i][j] = 1;
            Visit(grid, i - 1, j, ref val, ref res);
            Visit(grid, i + 1, j, ref val, ref res);
            Visit(grid, i, j - 1, ref val, ref res);
            Visit(grid, i, j + 1, ref val, ref res);
        }
    }
}
