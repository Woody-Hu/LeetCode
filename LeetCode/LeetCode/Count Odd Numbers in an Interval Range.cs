using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Count_Odd_Numbers_in_an_Interval_Range
    {
        public int CountOdds(int low, int high)
        {
            int interval = 0;
            if (low % 2 != 0 || high % 2 != 0)
                interval = (high - low) / 2 + 1;
            else
                interval = (high - low) / 2;
            return interval;
        }
    }
}
