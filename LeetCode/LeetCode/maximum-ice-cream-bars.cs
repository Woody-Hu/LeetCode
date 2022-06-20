using System;
namespace LeetCode
{
    public class maximum_ice_cream_bars
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            var res = 0;
            foreach (var item in costs)
            {
                if (item <= coins)
                {
                    res++;
                    coins -= item;
                }
                else
                {
                    break;
                }
            }

            return res;
        }
    }
}
