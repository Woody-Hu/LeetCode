using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumMatrix
    {
        private int[,] dpArray;

        public NumMatrix(int[,] matrix)
        {
            if (null == matrix || 0 == matrix.GetLength(0) || 0 == matrix.GetLength(1))
            {
                return;
            }

            dpArray = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) +1];

            for (int i = 1; i < matrix.GetLength(0) + 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) + 1; j++)
                {
                    dpArray[i, j] = dpArray[i - 1, j] + dpArray[i, j - 1] - dpArray[i - 1, j - 1] +
                                    matrix[i - 1, j - 1];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var maxRow = Math.Max(row1, row2);
            var minRow = Math.Min(row1, row2);
            var maxColumn = Math.Max(col1, col2);
            var minColumn = Math.Min(col1, col2);

            return dpArray[maxRow + 1, maxColumn + 1] - dpArray[maxRow + 1, minColumn] -
                   dpArray[minRow, maxColumn + 1] + dpArray[minRow, minColumn];

        }
    }
}
