using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class strobogrammatic_number_ii
	{
		private IList<string> _zeroList = new List<string>() { ""};

		private IList<string> _oneList = new List<string>() { "0", "1", "8" };

		public IList<string> FindStrobogrammatic(int n)
		{
			return Visit(n, true);
		}

		private IList<string> Visit(int n, bool calculateLast)
		{
            if (n == 0)
            {
				return _zeroList;
            }

            if (n == 1)
            {
				return _oneList;
            }

			var res = new List<string>();
            foreach (var item in Visit(n - 2, false))
            {
                if (!calculateLast)
                {
					res.Add("0" + item + "0");
                }

				res.Add("1" + item + "1");
				res.Add("9" + item + "6");
				res.Add("8" + item + "8");
				res.Add("6" + item + "9");
			}

			return res;
		}
	}
}

