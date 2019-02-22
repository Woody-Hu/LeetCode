using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Longest_Increasing_Subsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            var array = new int[nums.Length];
            var size = 0;
            foreach (var value in nums)
            {
                var i = 0;
                var j = size;
                while (i != j)
                {
                    var mid = (i + j) / 2;
                    if (array[mid] < value)
                    {
                        i = mid + 1;
                    }
                    else
                    {
                        j = mid;
                    }
                }

                array[i] = value;
                if (i == size)
                {
                    size++;
                }
            }

            return size;
        }
    }
}
