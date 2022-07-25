using System;
namespace LeetCode
{
    public class sort_the_matrix_diagonally
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            var m = mat.Length;
            var n = mat[0].Length;
            for (int k = 0; k < Math.Min(m,n) - 1; k++)
            {
                for (int i = 0; i < m - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (mat[i][j] > mat[i + 1][j + 1])
                        {
                            var temp = mat[i][j];
                            mat[i][j] = mat[i + 1][j + 1];
                            mat[i + 1][j + 1] = temp;
                        }
                    }
                }
            }

            return mat;
        }
    }
}
