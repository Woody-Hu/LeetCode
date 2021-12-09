using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Number_of_Strings_That_Appear_as_Substrings_in_Word
    {
        public int NumOfStrings(string[] patterns, string word)
        {
            var res = 0;
            var set = new HashSet<string>();
            foreach (var item in patterns)
            {
                if (set.Contains(item))
                {
                    res++;
                }
                else if (word.Contains(item))
                {
                    res++;
                    set.Add(item);
                }
            }

            return res;
        }
    }
}
