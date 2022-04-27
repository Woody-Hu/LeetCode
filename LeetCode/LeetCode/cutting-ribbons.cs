using System;
using System.Linq;

namespace LeetCode
{
    public class cutting_ribbons
    {
        public int MaxLength(int[] ribbons, int k)
        {
            var left = 0;
            var right = ribbons.Max();
            while (left < right)
            {
                var middle = (left + right + 1) / 2;
                if (Match(ribbons, k, middle))
                {
                    left = middle;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return left;
        }

        private bool Match(int[] ribbons, int k, int input)
        {
            var res = 0;
            foreach (var item in ribbons)
            {
                res += item / input;
            }

            return res >= k;
        }
    }
}
