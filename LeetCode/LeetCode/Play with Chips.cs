using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Play_with_Chips
    {
        public int MinCostToMoveChips(int[] chips)
        {
            var even = 0;
            var odd = 0;
            foreach (var item in chips)
            {
                if (item % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            return Math.Min(even, odd);
        }
    }
}
