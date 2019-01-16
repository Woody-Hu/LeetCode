using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Largest_Perimeter_Triangle
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);

            for (int i = A.Length - 1; i >1; i--)
            {
                if (A[i] < A[i-1] + A[i-2])
                {
                    return A[i] + A[i - 1] + A[i - 2];
                }
            }

            return 0;
        }
    }
}
