using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximal_Square
    {
        public int MaximalSquare(char[,] matrix)
        {
            var rowLength = matrix.GetLength(0);
            var columnLength = matrix.GetLength(1);

            var dp = new int[rowLength + 1, columnLength + 1];
            var maxLength = 0;

            for (int i = 1; i <= rowLength; i++)
            {
                for (int j = 1; j <= columnLength; j++)
                {
                    if (matrix[i-1,j-1] == '1')
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                        maxLength = Math.Max(maxLength, dp[i, j]);
                    }
                }
            }

            return maxLength * maxLength;
        }
    }
}
