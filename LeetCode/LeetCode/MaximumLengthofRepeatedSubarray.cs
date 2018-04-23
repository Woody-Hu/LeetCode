using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaximumLengthofRepeatedSubarray
    {
        public int FindLength(int[] A, int[] B)
        {
            int aLength = A.Length;

            int bLength = B.Length;


            int[] useArray = new int[bLength + 1];
            int returnValue = 0;
            for (int i = aLength - 1; i >=0; i--)
            {
                for (int j = 0; j < bLength; j++)
                {
                    returnValue = Math.Max(useArray[j] = A[i] == B[j] ? 1 + useArray[j + 1] : 0, returnValue);
                }
            }

            return returnValue;
        }
    }
}
