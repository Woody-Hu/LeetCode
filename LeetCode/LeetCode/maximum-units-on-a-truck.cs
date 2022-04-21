using System;
using System.Linq;

namespace LeetCode
{
    public class maximum_units_on_a_truck
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            var ordered = boxTypes.OrderByDescending(k => k[1]);
            var res = 0;
            foreach (var item in ordered)
            {
                var count = item[0];
                var usingCount = Math.Min(count, truckSize);
                res += usingCount * item[1];
                truckSize = truckSize - usingCount;
                if (usingCount == 0)
                {
                    break;
                }
            }

            return res;

        }
    }
}
