using System;
namespace LeetCode
{
    public class longest_line_of_consecutive_one_in_matrix
    {
        public int LongestLine(int[][] mat)
        {
            var res = 0;
            if (mat == null || mat.Length == 0 || mat[0].Length == 0)
            {
                return res;
            }

            var dp1 = new int[mat.Length, mat[0].Length];
            var dp2 = new int[mat.Length, mat[0].Length];
            var dp3 = new int[mat.Length, mat[0].Length];
            var dp4 = new int[mat.Length, mat[0].Length];
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        dp1[i, j] = 0;
                        dp2[i, j] = 0;
                        dp3[i, j] = 0;
                        dp4[i, j] = 0;
                    }
                    else
                    {
                        dp1[i, j] = i > 0 ? dp1[i - 1, j] + 1: 1;
                        dp2[i, j] = j > 0 ? dp2[i, j - 1] + 1 : 1;
                        dp3[i, j] = j > 0 && i > 0 ? dp3[i - 1, j - 1] + 1 : 1;
                        dp4[i, j] = j < mat[0].Length - 1 && i > 0 ? dp4[i - 1, j + 1] + 1 : 1;
                        res = Math.Max(res, dp1[i, j]);
                        res = Math.Max(res, dp2[i, j]);
                        res = Math.Max(res, dp3[i, j]);
                        res = Math.Max(res, dp4[i, j]);
                    }
                }
            }

            return res;
        }
    }
}
