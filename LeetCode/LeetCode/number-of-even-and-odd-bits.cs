using System;
namespace LeetCode
{
	public class number_of_even_and_odd_bits
	{
        public int[] EvenOddBit(int n)
        {
            var res = new int[2];
            var i = 0;
            while (n != 0)
            {
                res[i % 2] += n % 2;
                n /= 2;
                i++;
            }

            return res;
        }
    }
}

