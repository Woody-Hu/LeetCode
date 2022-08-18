using System;
namespace LeetCode
{
    public class reduction_operations_to_make_the_array_elements_equal
    {
        public int ReductionOperations(int[] nums)
        {
            Array.Sort(nums);
            var res = 0;
            var step = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    step++;
                }

                res += step;
            }

            return res;

        }
    }
}
