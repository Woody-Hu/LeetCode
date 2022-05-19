using System;
namespace LeetCode
{
    public class _sum_smaller
    {
        public int ThreeSumSmaller(int[] nums, int target)
        {
            Array.Sort(nums);
            var res = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > target)
                {
                    break;
                }

                res += TwoSumSmaller(nums, i + 1, target - nums[i]);
            }

            return res;
        }

        private int TwoSumSmaller(int[] nums, int start, int target)
        {
            var left = start;
            var right = nums.Length - 1;
            var res = 0;
            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    res += right - left;
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return res;

        }
    }
}
