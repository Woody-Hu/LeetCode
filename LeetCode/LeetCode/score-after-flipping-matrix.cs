using System;
namespace LeetCode
{
    public class score_after_flipping_matrix
    {
        public int MatrixScore(int[][] grid)
        {
            var rows = grid.Length;
            var columns = grid[0].Length;
            var res = rows * (1 << (columns - 1));
            for (int i = 1; i < columns; i++)
            {
                var oneCount = 0;
                for (int j = 0; j < rows; j++)
                {
                    if (grid[j][0] == 1)
                    {
                        oneCount += grid[j][i];
                    }
                    else
                    {
                        oneCount += (1 - grid[j][i]);
                    }
                }

                var k = Math.Max(oneCount, rows - oneCount);
                res += k * (1 << (columns - i - 1));
            }

            return res;
        }
    }
}
