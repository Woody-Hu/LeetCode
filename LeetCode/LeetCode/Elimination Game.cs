using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Elimination_Game
    {
        public int LastRemaining(int n)
        {
            var start = 1;
            var step = 1;
            var fromLeft = true;
            while (n != 1)
            {
                if (fromLeft || (n % 2) == 1)
                {
                    start = start + step;
                }

                n = n / 2;
                step = step * 2;
                fromLeft = !fromLeft;
            }

            return start;
        }
    }
}
