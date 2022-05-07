using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class buildings_with_an_ocean_view
	{
		public int[] FindBuildings(int[] heights)
		{
            if (heights.Length == 0)
            {
				return new int[0];
            }

			var res = new List<int>();
			var n = heights.Length;
			var max = heights[n - 1];
			res.Add(n - 1);
            for (int i = n - 2; i >= 0; i--)
            {
				var value = heights[i];
                if (value > max)
                {
					max = value;
					res.Add(i);
                }
            }

			res.Reverse();
			return res.ToArray();
		}
	}
}

