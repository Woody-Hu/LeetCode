using System;
namespace LeetCode
{
    public class minimum_operations_to_make_the_array_increasing
    {
        public int MinOperations(int[] nums)
        {
            var res = 0;
            for (int i = 0; nums.Length > 1 && i < nums.Length - 1; i++)
            {
                if (nums[i] >= nums[i+ 1])
                {
                    res += nums[i] - nums[i + 1] + 1;
                    nums[i + 1] = nums[i] + 1;
                }
            }

            return res;
        }
    }
}

