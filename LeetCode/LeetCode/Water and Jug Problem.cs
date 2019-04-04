using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Water_and_Jug_Problem
    {
        public bool CanMeasureWater(int x, int y, int z)
        {
            if (x + y < z)
            {
                return false;
            }

            if (x == z || y == z || x + y == z)
            {
                return true;
            }

            return z % GetGCD(x, y) == 0;
        }

        private int GetGCD(int x, int y)
        {
            while (y != 0)
            {
                var temp = y;
                y = x % y;
                x = temp;
            }

            return x;
        }
    }
}
