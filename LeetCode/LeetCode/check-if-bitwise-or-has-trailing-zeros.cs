using System;
namespace LeetCode
{
	public class check_if_bitwise_or_has_trailing_zeros
	{
        public bool HasTrailingZeros(int[] nums)
        {
            var even = nums.Length;
            foreach (var item in nums)
            {
                even -= item % 2;
            }

            return even >= 2;
        }
    }
}

