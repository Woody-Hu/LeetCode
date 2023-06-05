using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class minimize_string_length
	{
        public int MinimizedStringLength(string s)
        {
            var set = new HashSet<char>();
            foreach (var item in s)
            {
                set.Add(item);
            }

            return set.Count;
        }
    }
}

