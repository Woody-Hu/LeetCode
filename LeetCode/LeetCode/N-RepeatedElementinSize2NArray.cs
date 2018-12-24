using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class N_RepeatedElementinSize2NArray
    {
        public int RepeatedNTimes(int[] A)
        {
            Array.Sort(A);

            var midIndex = A.Length / 2;

            return A[midIndex] == A[midIndex + 1] ? A[midIndex] : A[midIndex - 1];
        }
    }
}
