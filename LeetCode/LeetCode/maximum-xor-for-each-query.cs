using System;
namespace LeetCode
{
    public class maximum_xor_for_each_query
    {
        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            var temp = new int[nums.Length];
            temp[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                temp[i] = nums[i] ^ temp[i - 1];
            }

            var res = new int[nums.Length];
            var value = (int)(Math.Pow(2, maximumBit) - 1);
            for (int i = 0; i < nums.Length; i++)
            {
                res[nums.Length - i - 1] = temp[i] ^ value;
            }

            return res;
        }
    }
}
