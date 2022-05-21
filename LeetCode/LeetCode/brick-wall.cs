using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class brick_wall
	{
		public int LeastBricks(IList<IList<int>> wall)
		{
			var dict = new Dictionary<int, int>();
            foreach (var item in wall)
            {
				var sum = 0;
                for (int i = 0; i < item.Count - 1; i++)
                {
					sum += item[i];
                    if (!dict.ContainsKey(sum))
                    {
                        dict[sum] = 0;
                    }

                    dict[sum]++;
                }
            }

            if (!dict.Any())
            {
                return wall.Count;
            }

            var max = dict.Values.Max();
            return wall.Count - max;
		}
	}
}

