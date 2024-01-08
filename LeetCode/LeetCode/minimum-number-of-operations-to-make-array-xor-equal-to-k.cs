using System;
namespace LeetCode
{
	public class minimum_number_of_operations_to_make_array_xor_equal_to_k
	{
        public int MinOperations(int[] nums, int k)
        {
            var xor = 0;
            foreach (var item in nums)
            {
                xor ^= item;
            }

            return BitCount(xor ^ k);
        }

        public int BitCount(int num)
        {
            uint bits = (uint)num;
            bits = bits - ((bits >> 1) & 0x55555555);
            bits = (bits & 0x33333333) + ((bits >> 2) & 0x33333333);
            bits = (bits + (bits >> 4)) & 0x0f0f0f0f;
            bits = (bits + (bits >> 8)) & 0x00ff00ff;
            bits = (bits + (bits >> 16)) & 0x0000ffff;
            return (int)bits;
        }
    }
}

