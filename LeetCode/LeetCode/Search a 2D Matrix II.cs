using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Search_a_2D_Matrix_II
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            var rowCount = matrix.GetLength(0);
            var columnCount = matrix.GetLength(1);
            var rowIndex = 0;
            var columnIndex = columnCount - 1;
            while (columnIndex >=0 && rowIndex < rowCount)
            {
                var value = matrix[rowIndex, columnIndex];
                if (target == value)
                {
                    return true;
                }

                if (target > value)
                {
                    rowIndex++;
                }
                else
                {
                    columnIndex--;
                }
            }


            return false;
        }
    }
}
