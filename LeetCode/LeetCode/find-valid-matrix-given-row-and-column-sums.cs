using System;
namespace LeetCode
{
    public class find_valid_matrix_given_row_and_column_sums
    {
        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int[][] res = new int[rowSum.Length][];
            for (int i = 0; i < rowSum.Length; i++)
            {
                res[i] = new int[colSum.Length];
            }

            for (int i = 0; i < rowSum.Length; i++)
            {
                for (int j = 0; j < colSum.Length; j++)
                {
                    res[i][j] = Math.Min(rowSum[i], colSum[j]);
                    rowSum[i] -= res[i][j];
                    colSum[j] -= res[i][j];
                }
            }

            return res;
        }
    }
}
