using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class find_maximum_number_of_string_pairs
	{
        public int MaximumNumberOfStringPairs(string[] words)
        {
            var set = new HashSet<string>();
            foreach (var item in words)
            {
                set.Add(item);
            }

            var res = 0;
            foreach (var item in words)
            {
                var charArray = item.ToCharArray();
                Array.Reverse(charArray);
                var reverse = new string(charArray);
                if (item == reverse)
                {
                    continue;
                }

                if (set.Contains(reverse))
                {
                    res++;
                    set.Remove(item);
                    set.Remove(reverse);
                }

            }

            return res;
        }
    }
}

