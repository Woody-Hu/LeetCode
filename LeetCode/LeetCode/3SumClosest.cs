using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int returnValue = nums[0] + nums[1] + nums[nums.Length - 1];

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int tempIndexStart = i + 1;
                int tempIndexEnd = nums.Length - 1;

                while (tempIndexStart < tempIndexEnd)
                {
                    int tempValue = nums[i] + nums[tempIndexStart] + nums[tempIndexEnd];

                    if (tempValue < target)
                    {
                        tempIndexStart++;
                    }
                    else 
                    {
                        tempIndexEnd--;
                    }

                    returnValue = Math.Abs(tempValue - target) < Math.Abs(returnValue - target) ? tempValue : returnValue;
                }
            }

            return returnValue;

        }
    }
}
