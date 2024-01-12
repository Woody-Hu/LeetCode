using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class minimum_string_length_after_removing_substrings
	{
        public int MinLength(string s)
        {
            var list = new List<char>();
            foreach (var item in s)
            {
                list.Add(item);
                var n = list.Count;
                if (n >= 2 && (list[n - 2] == 'A' && list[n - 1] == 'B' ||
                list[n - 2] == 'C' && list[n - 1] == 'D'))
                {
                    list.RemoveAt(n - 1);
                    list.RemoveAt(n - 2);
                }
            }

            return list.Count;
        }
    }
}

