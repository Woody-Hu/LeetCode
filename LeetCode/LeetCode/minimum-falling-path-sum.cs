using System;
namespace LeetCode
{
    public class minimum_falling_path_sum
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            var n = matrix.Length;
            for (int r = n-2; r >=0; r--)
            {
                for (int c = 0; c < n; c++)
                {
                    var temp = matrix[r + 1][c];
                    if (c > 0)
                    {
                        temp = Math.Min(temp, matrix[r + 1][c - 1]);
                    }

                    if (c < n - 1)
                    {
                        temp = Math.Min(temp, matrix[r + 1][c + 1]);
                    }

                    matrix[r][c] += temp;
                }
            }

            var res = int.MaxValue;
            foreach (var item in matrix[0])
            {
                res = Math.Min(item, res);
            }

            return res;
        }
    }
}
