using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class count_number_of_nice_subarrays
    {
        public int NumberOfSubarrays(int[] nums, int k)
        {
            var oddIndexs = new List<int>();
            oddIndexs.Add(-1);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddIndexs.Add(i);
                }
            }
            oddIndexs.Add(nums.Count());

            if (oddIndexs.Count < k)
            {
                return 0;
            }
            else if (oddIndexs.Count == nums.Length && nums.Length == k)
            {
                return 1;
            }

            var res = 0;
            for (int i = 1; i + k < oddIndexs.Count; i = i + 1)
            {
                res += (oddIndexs[i] - oddIndexs[i-1]) * (oddIndexs[i + k] - oddIndexs[i+k-1]);
            }

            return res;
        }
    }
}
