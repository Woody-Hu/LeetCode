using System;
namespace LeetCode
{
	public class minimum_time_to_make_rope_colorful
	{
        public int MinCost(string colors, int[] neededTime)
        {
            var l = colors.Length;
            var i = 0;
            var res = 0;
            while (i < l)
            {
                var cur = colors[i];
                var max = 0;
                var sum = 0;
                while (i < l && colors[i] == cur)
                {
                    max = Math.Max(max, neededTime[i]);
                    sum += neededTime[i];
                    i++;
                }

                res += sum - max;
            }

            return res;
        }
    }
}

