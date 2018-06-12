using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ArrangingCoins
    {
        public int ArrangeCoinsMethod(int n)
        {
            return (int)Math.Floor((Math.Sqrt((double)((long) n) * 8 + 1) -1)/2);
        }
    }
}
