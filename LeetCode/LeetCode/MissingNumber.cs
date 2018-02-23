using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public int MissingNumber(int[] nums)
        {
            if (null == nums || nums.Length == 0)
            {
                return 0;
            }

            int max = 0, min = 0, sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                max = Math.Max(max, nums[i]);
                min = Math.Min(min, nums[i]);
            }
            int correctSum = (nums.Length) * (nums.Length + 1) / 2;

            return correctSum - sum;
        }
    }
}
