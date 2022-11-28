using System;
namespace LeetCode
{
    public class difference_between_ones_and_zeros_in_row_and_column
    {
        public int[][] OnesMinusZeros(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var r = new int[m];
            var c = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        r[i]--;
                        c[j]--;
                    }
                    else
                    {
                        r[i]++;
                        c[j]++;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[i][j] = r[i] + c[j];
                }
            }

            return grid;
        }
    }
}
