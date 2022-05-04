using System;
using System.Linq;

namespace LeetCode
{
    public class sum_of_digits_in_the_minimum_number
    {
        public int SumOfDigits(int[] nums)
        {
            var min = nums.Min();
            var sum = 0;
            while (min > 0)
            {
                sum += min % 10;
                min = min / 10;
            }

            if (sum % 2 == 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
