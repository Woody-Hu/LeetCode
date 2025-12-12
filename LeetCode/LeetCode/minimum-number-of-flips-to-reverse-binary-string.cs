using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class minimum_number_of_flips_to_reverse_binary_string
    {
        public int MinimumFlips(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                sb.Append(n % 2);
                n /= 2;
            }
            int flips = 0;
            int length = sb.Length;
            for (int i = 0, j = length - 1; i < length; i++, j--)
            {
                if (sb[i] != sb[j])
                {
                    flips++;
                }
            }
            return flips;
        }
    }
}
