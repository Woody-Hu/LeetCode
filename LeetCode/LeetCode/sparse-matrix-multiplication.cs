using System;
namespace LeetCode
{
    public class sparse_matrix_multiplication
    {
        public int[][] Multiply(int[][] mat1, int[][] mat2)
        {
            var n = mat1.Length;
            var m = mat2[0].Length;
            var k = mat1[0].Length;
            var res = new int[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new int[m];
            }

            for (int i = 0; i < n; i++)
            { 
                for (int c = 0; c < k; c++)
                { 
                    if (mat1[i][c] == 0)
                    { 
                        continue; 
                    }
                    for (int j = 0; j < m; j++)
                    {
                        res[i][j] += mat1[i][c] * mat2[c][j];
                    }
                }
            }

            return res;
        }
    }
}
