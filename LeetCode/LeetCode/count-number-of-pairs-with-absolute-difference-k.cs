using System;
namespace LeetCode
{
    public class count_number_of_pairs_with_absolute_difference_k
    {
        public int CountKDifference(int[] nums, int k)
        {
            var res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}
