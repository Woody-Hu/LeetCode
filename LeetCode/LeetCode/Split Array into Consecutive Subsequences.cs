using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Split_Array_into_Consecutive_Subsequences
    {
        public bool IsPossible(int[] nums)
        {
            int first = nums[0], len = nums[nums.Length - 1] - first + 1;
            int[] count = new int[len + 1];
            foreach (var num in nums)
            {
                count[num - first + 1]++;
            }

            int start = 1, end = 1;
            while (end <= len)
            {
                while (end < len && count[end] <= count[end + 1]) end++;
                if (end - start < 2) return false;

                for (int i = start; i <= end; i++)
                {
                    count[i] = count[i] - 1;
                    if (count[i] == 0) start = i + 1;
                }
                while (end <= len && count[end] == 0)
                {
                    end++;
                    start = end;
                }
            }
            return true;
        }
    }
}
