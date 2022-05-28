using System;
namespace LeetCode
{
	public class matrix_diagonal_sum
	{
		public int DiagonalSum(int[][] mat)
		{
			var n = mat.Length;
			var mid = n / 2;
			var res = 0;
            for (int i = 0; i < n; i++)
            {
				res += mat[i][i] + mat[i][n - i - 1];
            }

			return res - mat[mid][mid] * (n % 2 == 0? 0 : 1);
		}
	}
}

