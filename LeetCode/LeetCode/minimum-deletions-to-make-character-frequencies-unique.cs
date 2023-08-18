using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class minimum_deletions_to_make_character_frequencies_unique
	{
        public int MinDeletions(string s)
        {
            var count = new int[26];
            foreach (var item in s)
            {
                count[item - 'a']++;
            }

            var list = new List<int>();
            foreach (var item in count)
            {
                list.Add(item);
            }

            list.Sort();
            var set = new HashSet<int>();
            var res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var cur = list[i];
                while (set.Contains(cur))
                {
                    res++;
                    cur--;
                }

                if (cur !=0)
                {
                    set.Add(cur);
                }
            }

            return res;
        }
    }
}

