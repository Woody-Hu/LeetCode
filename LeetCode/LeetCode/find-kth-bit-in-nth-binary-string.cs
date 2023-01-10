using System;
namespace LeetCode
{
    public class find_kth_bit_in_nth_binary_string
    {
        public char FindKthBit(int n, int k)
        {
            if (k == 1)
            {
                return '0';
            }

            var mid = 1 << (n - 1);
            if (k == mid)
            {
                return '1';
            }
            else if (k < mid)
            {
                return FindKthBit(n - 1, k);
            }
            else
            {
                k = mid * 2 - k;
                return Invert(FindKthBit(n - 1, k));
            }

        }

        public char Invert(char bit)
        {
            return (char)('0' + '1' - bit);
        }
    }
}
