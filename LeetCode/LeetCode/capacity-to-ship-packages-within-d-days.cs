using System;
using System.Linq;

namespace LeetCode
{
    public class capacity_to_ship_packages_within_d_days
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            var max = weights.Sum();
            var min = weights.Max();
            while (min < max)
            {
                var mid = (max + min) / 2;
                var useDays = 1;
                var current = 0;
                foreach (var item in weights)
                {
                    if (current + item > mid)
                    {
                        useDays++;
                        current = item;
                    }
                    else
                    {
                        current += item;
                    }
                }

                if (useDays > days)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }

            return min;
        }
    }
}
