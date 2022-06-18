using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class determine_if_string_halves_are_alike
	{
		public bool HalvesAreAlike(string s)
		{
			var set = new HashSet<char>("aeiouAEIOU");
			var lc = 0;
			var rc = 0;
            for (int i = 0; i < s.Length/2; i++)
            {
                if (set.Contains(s[i]))
                {
					lc++;
                }

                if (set.Contains(s[i + s.Length/2]))
                {
					rc++;
                }
            }

			return lc == rc;	
		}
	}
}

