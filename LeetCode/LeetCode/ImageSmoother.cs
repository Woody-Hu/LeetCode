using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ImageSmoother
    {
        public int[,] ImageSmootherMethod(int[,] M)
        {
            int lengthRow = M.GetLength(0);

            int lengthColumn = M.GetLength(1);

            int[,] returnValue = new int[lengthRow, lengthColumn];

            for (int i = 0; i < lengthRow; i++)
            {
                for (int j = 0; j < lengthColumn; j++)
                {
                    InnerMethod(M, returnValue, i, j, lengthRow, lengthColumn);
                }
            }

            return returnValue;
        }

        private void InnerMethod(int[,] inputMatrix,int[,] returnValue,int nowRowIndex,int nowColumnIndex,int maxRowLength,int maxColumnLength)
        {
            int useSum = 0;
            int useCount = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    var tempIdexRow = nowRowIndex + i;

                    var tempIndexColumn = nowColumnIndex + j;

                    if (tempIdexRow >= 0 && tempIdexRow < maxRowLength && tempIndexColumn >= 0 && tempIndexColumn < maxColumnLength)
                    {
                        useSum += inputMatrix[tempIdexRow, tempIndexColumn];
                        useCount++;
                    }
                }
            }

            returnValue[nowRowIndex, nowColumnIndex] = (int)Math.Floor((double)useSum / (double)useCount);
        }
    }
}
