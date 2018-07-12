using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class PeakIndexinaMountainArray
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int lowIndex = 0;
            int hightIndex = A.Length - 1;

            while (lowIndex < hightIndex)
            {
                var midIndex = (lowIndex + hightIndex) / 2;

                if (A[midIndex] < A[midIndex + 1])
                {
                    lowIndex = midIndex + 1;
                }
                else if (A[midIndex - 1] > A[midIndex])
                {
                    hightIndex = midIndex;
                }
                else
                {
                    return midIndex;
                }

            }

            return -1;

        }
    }
}