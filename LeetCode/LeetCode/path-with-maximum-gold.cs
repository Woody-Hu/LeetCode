using System;
namespace LeetCode
{
    public class path_with_maximum_gold
    {
        public int GetMaximumGold(int[][] grid)
        {
            int[][] dirs = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
            var res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        Visit(grid, i, j, dirs, 0, ref res);
                    }
                }
            }

            return res;
        }

        private void Visit(int[][] grid, int x, int y, int[][] dirs, int current, ref int res)
        {
            current += grid[x][y];
            res = Math.Max(res, current);

            var temp = grid[x][y];
            grid[x][y] = 0;
            foreach (var item in dirs)
            {
                int nx = x + item[0];
                int ny = y + item[1];
                if (nx >= 0 && nx < grid.Length && ny >= 0 && ny < grid[0].Length && grid[nx][ny] != 0)
                {
                    Visit(grid, nx, ny, dirs, current, ref res);
                }
            }

            grid[x][y] = temp;
        }
    }
}
