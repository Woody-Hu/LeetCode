using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Sum_of_Even_Numbers_After_Queries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var sum = 0;

            foreach (var value in A)
            {
                if (value % 2 == 0)
                {
                    sum += value;
                }
            }

            var returnValue = new int[queries.Length];
            var currentIndex = 0;

            foreach (var oneQuery in queries)
            {
                var index = oneQuery[1];
                var value = oneQuery[0];
                var oldValue = A[index];
                A[index] += value;
                var newValue = A[index];

                if (oldValue % 2 == 0)
                {
                    sum -= oldValue;
                }

                if (newValue % 2 == 0)
                {
                    sum += newValue;
                }

                returnValue[currentIndex++] = sum;
            }

            return returnValue;
        }
    }
}
