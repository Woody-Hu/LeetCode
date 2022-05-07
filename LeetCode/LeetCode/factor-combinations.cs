using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class factor_combinations
	{
		public IList<IList<int>> GetFactors(int n)
		{
			return Visit(2, n);
		}

		private IList<IList<int>> Visit(int start, int value)
		{
            if (value == 1)
            {
				return new List<IList<int>>();
            }

			var end = (int)Math.Sqrt(value);
			var res = new List<IList<int>>();
            for (int i = start; i <= end; i++)
            {
                if (value % i != 0)
                {
					continue;
                }

				var list = new List<int>() { i, value / i };
				res.Add(list);
				var nextLists = Visit(i, value / i);
                foreach (var item in nextLists)
                {
					item.Add(i);
					res.Add(item);
                }
            }

			return res;
		}
	}
}

