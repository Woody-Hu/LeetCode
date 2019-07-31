using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Time_Difference
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            var bitArray = new BitArray(24 * 60);

            for (int i = 0; i < timePoints.Count; i++)
            {
                int hour = (timePoints[i][0] - '0') * 10 + timePoints[i][1] - '0';
                int minute = (timePoints[i][3] - '0') * 10 + timePoints[i][4] - '0';
                int key = hour * 60 + minute;
                if (bitArray.Get(key))
                {
                    return 0;
                }

                bitArray.Set(key, true);
            }

            var first = -1;
            var prev = -1;
            var minDiff = int.MaxValue;
            for (int i = 0; i < bitArray.Length; i++)
            {
                if (bitArray.Get(i))
                {
                    if (first == -1)
                    {
                        first = i;
                    }
                    else
                    {
                        minDiff = Math.Min(minDiff, i - prev);
                    }
                    prev = i;
                }
            }
            return Math.Min(minDiff, 24 * 60 - prev + first);

        }
    }
}
