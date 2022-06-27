using System;
namespace LeetCode
{
    public class sum_of_all_subset_xor_totals
    {
        public int SubsetXORSum(int[] nums)
        {
            var res = 0;
            foreach (var item in nums)
            {
                res |= item;
            }

            return res << (nums.Length - 1);
        }
    }
}
