using System;
namespace LeetCode
{
	public class largest_magic_square
	{
        public int LargestMagicSquare(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            var rowSum = new int[m + 1, n + 1];
            var colSum = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    rowSum[i, j] = rowSum[i, j - 1] + grid[i - 1][j - 1];
                    colSum[i, j] = colSum[i - 1, j] + grid[i - 1][j - 1];
                }
            }

            for (int k = Math.Min(m,n); k > 1; k--)
            {
                for (int i = 0; i + k - 1 < m; i++)
                {
                    for (int j = 0; j + k - 1 < n; j++)
                    {
                        var i2 = i + k - 1;
                        var j2 = j + k - 1;
                        if (Check(grid, i, j, i2, j2, rowSum, colSum))
                        {
                            return k;
                        }
                    }
                }
            }

            return 1;
        }

        private bool Check(int[][] grid, int x1, int y1, int x2, int y2, int[,] rowSum, int[,] colSum)
        {
            var value = rowSum[x1 + 1, y2 + 1] - rowSum[x1 + 1, y1];
            for (int i = x1 + 1; i <= x2; i++)
            {
                if (rowSum[i + 1, y2 +1] - rowSum[i + 1, y1] != value)
                {
                    return false;
                }
            }

            for (int j = y1; j <= y2; j++)
            {
                if (colSum[x2 + 1, j +1] - colSum[x1, j + 1] != value)
                {
                    return false;
                }
            }

            var s = 0;
            for (int i = x1, j = y1; i <= x2; i++, j++)
            {
                s += grid[i][j];
            }

            if (s != value)
            {
                return false;
            }

            s = 0;
            for (int i = x1, j = y2; i <= x2; i++, j--)
            {
                s += grid[i][j];
            }

            if (s != value)
            {
                return false;
            }

            return true;
        }

    }
}

