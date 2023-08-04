using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class card_flipping_game
	{
        public int Flipgame(int[] fronts, int[] backs)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < fronts.Length; i++)
            {
                if (fronts[i] == backs[i])
                {
                    set.Add(fronts[i]);
                }
            }

            var res = 3000;
            foreach (var item in fronts)
            {
                if (item < res && !set.Contains(item))
                {
                    res = item;
                }
            }

            foreach (var item in backs)
            {
                if (item < res && !set.Contains(item))
                {
                    res = item;
                }
            }

            return res % 3000;
        }
    }
}

