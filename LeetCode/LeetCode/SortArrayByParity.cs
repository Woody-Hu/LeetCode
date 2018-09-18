using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SortArrayByParity
    {
        public int[] SortArrayByParityMethod(int[] A)
        {
            int[] returnValue = new int[A.Length];

            int useEvenIndex = 0;
            int useOddIndex = A.Length - 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    returnValue[useEvenIndex++] = A[i];
                }
                else
                {
                    returnValue[useOddIndex--] = A[i];
                }
            }

            return returnValue;
        }
    }
}
