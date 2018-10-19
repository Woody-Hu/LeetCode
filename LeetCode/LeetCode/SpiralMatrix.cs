using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            int[] returnValue = new int[matrix.Length];

            int tempIndex = 0;

            int rowStart = 0;
            int rowEnd = matrix.GetLength(0)-1;

            int columnStart = 0;
            int columnEnd = matrix.GetLength(1)-1;

            while (rowStart <= rowEnd && columnStart <= columnEnd)
            {
                for (int i = columnStart; i <= columnEnd; i++)
                {
                    returnValue[tempIndex++] = matrix[rowStart, i];
                }

                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    returnValue[tempIndex++] = matrix[i, columnEnd];
                }

                columnEnd--;

                if (rowStart<=rowEnd)
                {
                    for (int i = columnEnd; i >= columnStart; i--)
                    {
                        returnValue[tempIndex++] = matrix[rowEnd, i];
                    }

                }


                rowEnd--;

                if (columnStart<=columnEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        returnValue[tempIndex++] = matrix[i, columnStart];
                    }
                }
              

                columnStart++;

            }

            return new List<int>(returnValue);

        }
    }
}
