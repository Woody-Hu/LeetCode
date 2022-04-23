using System;
using System.Linq;

namespace LeetCode
{
    public class sell_diminishing_valued_colored_balls
    {
        public int MaxProfit(int[] inventory, int orders)
        {
            Array.Sort(inventory);
            var mod = 1000000007;
            var l = 0;
            var r = inventory.Max();
            var target = 0;
            while (l < r)
            {
                var mid = (l + r) / 2;
                var sum = inventory.Where(k => k >= mid).Select(k => k - mid).Sum();
                if (sum > orders)
                {
                    l = mid + 1;
                }
                else
                {
                    target = mid;
                    r = mid - 1;
                }
            }

            var rest = orders - inventory.Where(k => k >= target).Select(k => k - target).Sum();
            long res = 0l;
            foreach (var item in inventory)
            {
                if (item < target)
                {
                    continue;
                }

                if (rest > 0)
                {
                    res += Calculate(item, target) % mod;
                    rest--;
                }
                else
                {
                    res += Calculate(item, target + 1) % mod;
                }
            }

            return (int)(res % mod);

        }

        private long Calculate(long value, long target)
        {
            return (value + target) * (value - target + 1)/2l;
        }

    }
}

