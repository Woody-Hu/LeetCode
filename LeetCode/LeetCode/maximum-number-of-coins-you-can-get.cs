using System;
namespace LeetCode
{
    public class maximum_number_of_coins_you_can_get
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);
            var times = piles.Length / 3;
            var i = piles.Length - 2;
            var res = 0;
            for (int j = 0; j < times; j++)
            {
                res += piles[i];
                i = i - 2;
            }

            return res;
        }
    }
}
