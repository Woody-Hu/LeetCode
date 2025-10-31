using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class remove_zeros_in_decimal_representation
    {
        public long RemoveZeros(long n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                long digit = n % 10;
                if (digit != 0)
                {
                    sb.Insert(0, digit);
                }
                n /= 10;
            }
            return sb.Length == 0 ? 0 : long.Parse(sb.ToString());

        }
    }
}
