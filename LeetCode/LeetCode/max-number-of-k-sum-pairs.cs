using System;
namespace LeetCode
{
	public class max_number_of_k_sum_pairs
	{
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            var res = 0;
            var l = 0;
            var r = nums.Length - 1;
            var sum = 0;
            while (l < r)
            {
                sum = nums[l] + nums[r];
                if (sum == k)
                {
                    res++;
                    r--;
                    l++;
                }
                else if (sum > k)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            return res;
        }
    }
}

