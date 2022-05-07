using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class shortest_way_to_form_string
	{
		public int ShortestWay(string source, string target)
		{
			var sp = 0;
			var tp = 0;
			var res = 0;
            while (tp < target.Length)
            {
				var currentTp = tp;
                while (tp < target.Length && sp < source.Length)
                {
                    if (source[sp] == target[tp])
                    {
                        sp++;
                        tp++;
                    }
                    else
                    {
                        sp++;
                    }
                }

                if (tp > currentTp)
                {
                    res++;
                }
                else
                {
                    return -1;
                }

                sp = 0;
            }

            return res;		
		}
	}
}

