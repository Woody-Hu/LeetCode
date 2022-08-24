using System;
namespace LeetCode
{
    public class sum_of_absolute_differences_in_a_sorted_array
    {
        public int[] GetSumAbsoluteDifferences(int[] nums)
        {
            var res = new int[nums.Length];
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = rightSum - leftSum + nums[i] * (2 * i - nums.Length);
                leftSum += nums[i];
                rightSum -= nums[i];
            }

            return res;
        }
    }
}
