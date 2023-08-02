using System;
namespace LeetCode
{
	public class closest_divisors
	{
        public int[] ClosestDivisors(int num)
        {
            var divisor = num == 1 ? num + 1 : num + 2;
            var i = (int)Math.Sqrt(divisor);
            while (divisor % i > 1)
            {
                i--;
            }

            return new int[] { i, divisor / i };
        }
    }
}

