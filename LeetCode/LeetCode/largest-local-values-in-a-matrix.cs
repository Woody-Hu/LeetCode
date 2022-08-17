using System;
namespace LeetCode
{
    public class largest_local_values_in_a_matrix
    {
        public int[][] LargestLocal(int[][] grid)
        {
            var n = grid.Length;
            var size = 3;
            var res = new int[n - size + 1][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[n - size + 1];
            }

            for (int i = 0; i <= n - size; i++)
            {
                for (int j = 0; j <= n - size; j++)
                {
                    res[i][j] = FindMax(grid, i, j, size);
                }
            }

            return res;
        }

        private int FindMax(int[][] grid, int x, int y, int size)
        {
            var res = grid[x][y];
            for (int i = x; i < x + size; i++)
            {
                for (int j = y; j < y+ size; j++)
                {
                    if (grid[i][j] >= res)
                    {
                        res = grid[i][j];
                    }
                }
            }

            return res;
        }
    }
}
