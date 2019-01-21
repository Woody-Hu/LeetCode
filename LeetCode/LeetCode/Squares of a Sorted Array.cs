using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Squares_of_a_Sorted_Array
    {
        public int[] SortedSquares(int[] A)
        {
            var squaredArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                squaredArray[i] = A[i] * A[i];
            }

            Array.Sort(squaredArray);
            return squaredArray;
        }
    }
}
