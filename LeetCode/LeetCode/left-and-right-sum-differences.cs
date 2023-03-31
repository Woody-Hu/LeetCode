using System;
using System.Linq;

namespace LeetCode
{
	public class left_and_right_sum_differences
	{
        public int[] LeftRigthDifference(int[] nums)
        {
            var total = nums.Sum();
            var leftSum = 0;
            var rightSum = total;
            var res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];
                rightSum -= value;
                res[i] = Math.Abs(leftSum - rightSum);
                leftSum += value;
            }

            return res;
        }
    }
}

