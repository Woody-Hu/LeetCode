using System;
namespace LeetCode
{
    public class maximum_bags_with_full_capacity_of_rocks
    {
        public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
        {
            var diff = new int[capacity.Length];
            for (int i = 0; i < capacity.Length; i++)
            {
                diff[i] = capacity[i] - rocks[i];
            }

            Array.Sort(diff);
            var res = 0;
            foreach (var item in diff)
            {
                if (item < 0)
                {
                    continue;
                }

                if (additionalRocks - item >= 0)
                {
                    res++;
                    additionalRocks -= item;
                }
            }

            return res;
        }
    }
}
