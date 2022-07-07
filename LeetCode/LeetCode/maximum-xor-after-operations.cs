using System;
namespace LeetCode
{
    public class maximum_xor_after_operations
    {
        public int MaximumXOR(int[] nums)
        {
            var res = 0;
            foreach (var item in nums)
            {
                res |= item;
            }

            return res;
        }
    }
}
