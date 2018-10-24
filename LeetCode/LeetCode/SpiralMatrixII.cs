using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SpiralMatrixII
    {
        public int[,] GenerateMatrix(int n)
        {
            int[,] returnValue = new int[n,n];

            int rowStart = 0;
            int rowEnd = n - 1;
            int columnStart = 0;
            int columnEnd = n - 1;
            int nowValue = 0;
            while (rowStart <= rowEnd && columnStart <= columnEnd)
            {
                for (int i = columnStart; i <= columnEnd; i++)
                {
                    returnValue[rowStart, i] = ++nowValue;
                }

                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    returnValue[i, columnEnd] = ++nowValue;
                }

                columnEnd--;

                if (rowEnd >= rowStart)
                {
                    for (int i = columnEnd; i >=columnStart; i--)
                    {
                        returnValue[rowEnd, i] = ++nowValue;
                    }
                }

                rowEnd--;

                if (columnEnd >= columnStart)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        returnValue[i, columnStart] = ++nowValue;
                    }
                }

                columnStart++;
            }

            return returnValue;

        }
    }
}
