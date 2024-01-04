using System;
namespace LeetCode
{
	public class WHnhjV
	{
        public int GiveGem(int[] gem, int[][] operations)
        {
            foreach (var item in operations)
            {
                var x = item[0];
                var y = item[1];
                var value = gem[x] / 2;
                gem[x] -= value;
                gem[y] += value;
            }

            var min = gem[0];
            var max = gem[1];
            foreach (var item in gem)
            {
                min = Math.Min(item, min);
                max = Math.Max(item, max);
            }

            return max - min;
        }
    }
}

