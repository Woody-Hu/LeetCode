using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class mirror_distance_of_an_integer
    {
        public int MirrorDistance(int n)
        {
            return Math.Abs(n - Reverse(n));
        }

        public int Reverse(int n)
        {
            int reversed = 0;
            while (n != 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }
            return reversed;
        }
    }
}
