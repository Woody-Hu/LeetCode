using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximize_Sum_Of_Array_After_K_Negations
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            Array.Sort(A);

            var sum = 0;
            var count = 0;
            var minPost = int.MaxValue;
            foreach (var oneValue in A)
            {
                var useValue = oneValue;
                if (oneValue < 0 && ++count <= K)
                {
                    useValue = -oneValue;
                }

                sum += useValue;
                minPost = Math.Min(minPost, useValue);
            }

            if (count > K || (K - count) % 2 == 0)
            {
                return sum;
            }
            else
            {
                return sum - 2 * minPost;
            }
        }
    }
}
