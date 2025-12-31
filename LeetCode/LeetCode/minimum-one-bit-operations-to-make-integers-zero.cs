using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class minimum_one_bit_operations_to_make_integers_zero
    {
        public int MinimumOneBitOperations(int n)
        {
            int ans = 0;
            while (n != 0)
            {
                ans ^= n;
                n >>= 1;
            }
            return ans;
        }
    }
}
