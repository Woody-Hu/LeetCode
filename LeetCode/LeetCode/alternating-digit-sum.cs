using System;
namespace LeetCode
{
	public class alternating_digit_sum
	{
        public int AlternateDigitSum(int n)
        {
            var res = 0;
            var sign = 1;
            while (n > 0)
            {
                res += n % 10 * sign;
                sign = -sign;
                n /= 10;
            }

            return res * -sign;
        }
    }
}

