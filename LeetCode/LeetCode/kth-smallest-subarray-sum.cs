using System;
using System.Linq;

namespace LeetCode
{
    public class kth_smallest_subarray_sum
    {
        public int KthSmallestSubarraySum(int[] nums, int k)
        {
            int min = nums.Min();
            var sum = nums.Sum();
            int low = min, high = sum;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                int count = GetSubArrayCount(nums, mid);
                if (count < k)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }

        private int GetSubArrayCount(int[] nums, int limit)
        {
            var res = 0;
            var sum = 0;
            var n = nums.Length;
            var left = 0;
            var right = 0;
            while (right < n)
            {
                sum += nums[right];
                while (sum > limit)
                {
                    sum -= nums[left];
                    left++;
                }

                res += right - left + 1;
                right++;
            }

            return res;
        }
    }
}
