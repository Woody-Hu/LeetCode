using System;
namespace LeetCode
{
    public class difference_between_element_sum_and_digit_sum_of_an_array
    {
        public int DifferenceOfSum(int[] nums)
        {
            var res1 = 0;
            var res2 = 0;
            foreach (var item in nums)
            {
                res1 += item;
                var temp = item;
                while (temp > 0)
                {
                    res2 += temp % 10;
                    temp = temp / 10;
                }
            }

            return Math.Abs(res1 - res2);
        }
    }
}
