using System;
namespace LeetCode
{
	public class sum_of_squares_of_special_elements
	{
        public int SumOfSquares(int[] nums)
        {
            var res = 0;
            var n = nums.Length;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    res += nums[i - 1] * nums[i - 1];
                }
            }

            return res;
        }
    }
}

