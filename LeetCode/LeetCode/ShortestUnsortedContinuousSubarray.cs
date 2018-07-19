using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int tempRight = 0;

            int tempValue = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]<tempValue)
                {
                    tempRight = i;
                }
                else
                {
                    tempValue = nums[i];
                }
            }

            int tempLeft = nums.Length - 1;
            tempValue = nums[nums.Length - 1];

            for (int i = nums.Length - 1; i >=0; i--)
            {
                if (nums[i]>tempValue)
                {
                    tempLeft = i;
                }
                else
                {
                    tempValue = nums[i];
                }
            }

            return tempRight - tempLeft <= 0 ? 0 : tempRight - tempLeft + 1;

        }
    }
}
