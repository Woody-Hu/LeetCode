using System;
using System.Linq;

namespace LeetCode
{
	public class closest_dessert_cost
	{
        public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
        {
            var min = baseCosts.Min();
            if (min >= target)
            {
                return min;
            }

            var can = new bool[target + 1];
            var res = 2 * target - min;
            foreach (var item in baseCosts)
            {
                if (item <= target)
                {
                    can[item] = true;
                }
                else
                {
                    res = Math.Min(res, item);
                }
            }

            foreach (var item in toppingCosts)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = target; j > 0; j--)
                    {
                        if (can[j] && item + j > target)
                        {
                            res = Math.Min(res, j + item);
                        }

                        if (j - item > 0 )
                        {
                            can[j] = can[j] | can[j - item];
                        }
                    }
                }
            }

            for (int i = 0; i <= res - target; ++i)
            {
                if (can[target - i])
                {
                    return target - i;
                }
            }

            return res;
        }
    }
}

