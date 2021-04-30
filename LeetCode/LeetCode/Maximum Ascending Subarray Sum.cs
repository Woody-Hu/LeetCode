using System;
namespace LeetCode
{
    public class Maximum_Ascending_Subarray_Sum
    {
        public int MaxAscendingSum(int[] nums)
        {
            var res = nums[0];
            var currentSum = nums[0];
            var top = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= top)
                {
                    res = Math.Max(res, currentSum);
                    currentSum = nums[i];
                }
                else
                {
                    currentSum += nums[i];
                }

                top = nums[i];
            }

            res = Math.Max(res, currentSum);
            return res;

        }
    }
}
