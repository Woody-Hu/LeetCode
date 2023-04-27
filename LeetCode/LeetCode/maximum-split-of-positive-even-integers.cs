using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class maximum_split_of_positive_even_integers
	{
        public IList<long> MaximumEvenSplit(long finalSum)
        {
            var res = new List<long>();
            if (finalSum % 2 != 0)
            {
                return res;
            }

            var temp = finalSum;
            var current = 2l;
            while (temp - current >= 0)
            {
                res.Add(current);
                temp -= current;
                current += 2;
            }

            if (temp > 0)
            {
                temp += res[res.Count - 1];
                res.RemoveAt(res.Count - 1);
                res.Add(temp);
            }

            return res;
        }
    }
}

