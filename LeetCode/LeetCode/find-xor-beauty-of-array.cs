using System;
namespace LeetCode
{
    public class find_xor_beauty_of_array
    {
        public int XorBeauty(int[] nums)
        {
            var res = 0;
            foreach (var item in nums)
            {
                res ^= item;
            }

            return res;
        }
    }
}
