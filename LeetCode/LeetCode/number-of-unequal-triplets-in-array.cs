using System;
namespace LeetCode
{
	public class number_of_unequal_triplets_in_array
	{
        public int UnequalTriplets(int[] nums)
        {
            Array.Sort(nums);
            var res = 0;
            var n = nums.Length;
            for (int i = 0, j = 0; i < n; i=j)
            {
                while (j < n && nums[i] == nums[j])
                {
                    j++;
                }

                res += i * (j - i) * (n - j);
            }

            return res;

        }
    }
}

