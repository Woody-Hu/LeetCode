using System;
namespace LeetCode
{
    public class count_equal_and_divisible_pairs_in_an_array
    {
        public int CountPairs(int[] nums, int k)
        {
            var res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && (i*j)%k == 0)
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}

