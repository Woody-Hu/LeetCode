using System;
namespace LeetCode
{
	public class largest_1_bordered_square
	{
        public int Largest1BorderedSquare(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var left = new int[m + 1, n + 1];
            var up = new int[m + 1, n + 1];
            var res = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (grid[i - 1][j - 1] == 1)
                    {
                        left[i, j] = left[i, j - 1] + 1;
                        up[i, j] = up[i - 1, j] + 1;
                        var l = Math.Min(left[i, j], up[i, j]);
                        while (left[i - l + 1, j] < l || up[i, j - l + 1] < l)
                        {
                            l--;
                        }

                        res = Math.Max(res, l);
                    }
                }
            }

            return res * res;
        }
    }
}

