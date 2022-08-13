using System;
namespace LeetCode
{
    public class number_of_arithmetic_triplets
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            var array = new int[201];
            var res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];
                if (value >= 2 * diff)
                {
                    res += array[value - diff] * array[value - 2 * diff];
                }

                array[value] += 1;
            }

            return res;
        }
    }
}

