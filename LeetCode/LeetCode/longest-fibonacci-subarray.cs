using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class longest_fibonacci_subarray
    {
        public int LongestSubarray(int[] nums)
        {
            int n = nums.Length;
            if (n < 3) return n;
            int maxLength = 2;
            int currentLength = 2;
            for (int i = 2; i < n; i++)
            {
                if (nums[i] == nums[i - 1] + nums[i - 2])
                {
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                }
                else
                {
                    currentLength = 2;
                }
            }
            return maxLength;


        }
    }
}
