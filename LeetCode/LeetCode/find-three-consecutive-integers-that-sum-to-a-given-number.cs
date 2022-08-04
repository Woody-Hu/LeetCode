using System;
namespace LeetCode
{
    public class find_three_consecutive_integers_that_sum_to_a_given_number
    {
        public long[] SumOfThree(long num)
        {
            var target = num / 3;
            if (target * 3 == num)
            {
                return new long[] { target - 1, target, target + 1 };
            }
            else
            {
                return new long[0];
            }
        }
    }
}
