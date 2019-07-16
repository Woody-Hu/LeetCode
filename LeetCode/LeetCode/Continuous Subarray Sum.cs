using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Continuous_Subarray_Sum
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            int len = nums.Length;
            int[] temp = new int[len];

            for (int i = 0; i < len; i++)
            {
                temp[i] = nums[i];
            }

            for (int i = 2; i <= len; i++)
            {
                for (int j = 0; j < len - i + 1; j++)
                {
                    temp[j] = temp[j] + nums[j + i - 1];
                    if (k == 0 && temp[j] == 0 || k != 0 && temp[j] % k == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
