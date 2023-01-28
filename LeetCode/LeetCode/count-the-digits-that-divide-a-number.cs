using System;
namespace LeetCode
{
    public class count_the_digits_that_divide_a_number
    {
        public int CountDigits(int num)
        {
            var res = 0;
            var temp = num;
            while (temp > 0)
            {
                if (num % (temp % 10) == 0)
                {
                    res += 1;
                }

                temp = temp / 10;
            }

            return res;
        }
    }
}

