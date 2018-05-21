using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (null == nums || 0 == nums.Length)
            {
                return 0;
            }

            int maxLength = 1;
            int tempLength = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i+1])
                {
                    tempLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, tempLength);
                    tempLength = 1;
                }
            }

            maxLength = Math.Max(maxLength, tempLength);

            return maxLength;
        }
    }
}
