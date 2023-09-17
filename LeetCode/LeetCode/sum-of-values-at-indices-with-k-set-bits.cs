using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class sum_of_values_at_indices_with_k_set_bits
	{
        public int SumIndicesWithKSetBits(IList<int> nums, int k)
        {
            var res = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (NumberOfSetBits(i) == k)
                {
                    res += nums[i];
                }
            }

            return res;
        }

        static long NumberOfSetBits(long i)
        {
            i = i - ((i >> 1) & 0x5555555555555555);
            i = (i & 0x3333333333333333) + ((i >> 2) & 0x3333333333333333);
            return (((i + (i >> 4)) & 0xF0F0F0F0F0F0F0F) * 0x101010101010101) >> 56;
        }
    }
}

