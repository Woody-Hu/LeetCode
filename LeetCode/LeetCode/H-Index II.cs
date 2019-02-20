using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class H_Index_II
    {
        public int HIndex(int[] citations)
        {
            var length = citations.Length;
            var left = 0;
            var right = length - 1;
            var mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (citations[mid] == length - mid)
                {
                    return citations[mid];
                }
                else if (citations[mid] > length - mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return length - (right + 1);
        }
    }
}
