
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class FlippinganImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] returnValue = new int[A.Length][];

            for (int i = 0; i < returnValue.Length; i++)
            {
                var tempLength = A[i].Length;
                returnValue[i] = new int[tempLength];

                for (int j = 0; j < tempLength; j++)
                {
                    returnValue[i][j] = Math.Abs(A[i][tempLength - 1 - j] - 1);
                }   
            }

            return returnValue;
        }
    }
}