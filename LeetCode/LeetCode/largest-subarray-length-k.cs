using System;
namespace LeetCode
{
    public class largest_subarray_length_k
    {
        public int[] LargestSubarray(int[] nums, int k)
        {
            if (nums.Length < k)
            {
                return new int[0];
            }
            else if (nums.Length == k)
            {
                return nums;
            }

            var res = new int[k];
            var maxValue = nums[0];
            var maxIndex = 0;

            for (int i = 0; i + k - 1 < nums.Length; i++)
            {
                var value = nums[i];
                if (value > maxValue)
                {
                    maxValue = value;
                    maxIndex = i;
                }
            }

            Array.Copy(nums, maxIndex, res, 0, k);
            return res;
        }
    }
}
