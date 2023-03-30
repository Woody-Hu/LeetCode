using System;
namespace LeetCode
{
	public class best_sightseeing_pair
	{
        public int MaxScoreSightseeingPair(int[] values)
        {
            var res = 0;
            var max = values[0] - 0;

            for (int i = 1; i < values.Length; i++)
            {
                res = Math.Max(res, max + values[i] - i);
                max = Math.Max(max, values[i] + i);
            }

            return res;
        }
    }
}

