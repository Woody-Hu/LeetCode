using System;
namespace LeetCode
{
    public class matrix_block_sum
    {
        public int[][] MatrixBlockSum(int[][] mat, int k)
        {
            var rows = mat.Length;
            var columns = mat[0].Length;
            var sum = new int[rows + 1, columns + 1];
            var res = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                res[i] = new int[columns];
            }

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + mat[i - 1][j - 1];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var upX = Math.Min(i + k + 1, rows);
                    var upY = Math.Min(j + k + 1, columns);
                    var downX = Math.Max(i - k, 0);
                    var downY = Math.Max(j - k, 0);
                    res[i][j] = sum[upX, upY] - sum[upX, downY] - sum[downX, upY] + sum[downX, downY];
                }
            }

            return res;
        }
    }
}
