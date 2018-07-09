using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class NondecreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            var tempCount = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    tempCount++;
                    if (i > 0 && nums[i + 1] < nums[i - 1]) nums[i + 1] = nums[i];
                    else nums[i] = nums[i + 1];
                }
            }

            return tempCount<=1;
        }
    }
}