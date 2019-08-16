using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Partition_Array_into_Disjoint_Intervals
    {
        public int PartitionDisjoint(int[] A)
        {
            int globalMax = A[0];
            int leftMax = A[0];
            int boundary = 0;

            for (int i = 0; i < A.Length; i++)
            {
                globalMax = Math.Max(globalMax, A[i]);
                if (A[i] < leftMax)
                {
                    boundary = i;
                    leftMax = Math.Max(globalMax, leftMax);
                }
            }
            return boundary + 1;
        }
    }
}
