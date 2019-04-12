using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Kth_Smallest_Element_in_a_Sorted_Matrix
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            int lo = matrix[0][0], hi = matrix[matrix.Length - 1][matrix[0].Length - 1] + 1;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                int count = 0, j = matrix[0].Length - 1;
                for (int i = 0; i < matrix.Length; i++)
                {
                    while (j >= 0 && matrix[i][j] > mid) j--;
                    count += (j + 1);
                }
                if (count < k) lo = mid + 1;
                else hi = mid;
            }
            return lo;
        }
    }
}
