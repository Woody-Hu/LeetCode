using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class kids_with_the_greatest_number_of_candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var res = new List<bool>(candies.Length);
            var max = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    res.Add(true);
                }
                else
                {
                    res.Add(false);
                }
            }

            return res;
        }
    }
}
