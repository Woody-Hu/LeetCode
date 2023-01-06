using System;
namespace LeetCode
{
    public class largest_submatrix_with_rearrangements
    {
        public int LargestSubmatrix(int[][] matrix)
        {
            var res = 0;
            var n = matrix.Length;
            var m = matrix[0].Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        matrix[i][j] += matrix[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Array.Sort(matrix[i]);
                for (int j = m-1; j >=0; j--)
                {
                    var height = matrix[i][j];
                    res = Math.Max(res, height * (m - j));
                }
            }

            return res;
        }
    }
}
