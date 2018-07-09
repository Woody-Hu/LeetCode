using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            int[][] returnValue = new int[A[0].Length][];

            for (int i = 0; i < A[0].Length; i++)
            {
                returnValue[i] = new int[A.Length];

                for (int j = 0; j < returnValue[i].Length; j++)
                {
                    returnValue[i][j] = A[j][i];
                }
            }

            return returnValue;
        }
    }
}