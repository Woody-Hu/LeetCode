using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class sequential_digits
	{
        public IList<int> SequentialDigits(int low, int high)
        {
            var res = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                var cur = i;
                for (int j = i + 1; j <= 9; j++)
                {
                    cur = cur * 10 + j;
                    if (cur >= low && cur <= high)
                    {
                        res.Add(cur);
                    }
                }

            }

            res.Sort();
            return res;
        }
    }
}

