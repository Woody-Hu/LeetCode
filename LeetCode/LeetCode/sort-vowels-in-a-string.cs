using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class sort_vowels_in_a_string
	{
        public string SortVowels(string s)
        {
            var vowelSet = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            var list = new List<char>();
            foreach (var item in s)
            {
                if (vowelSet.Contains(Char.ToLower(item)))
                {
                    list.Add(item);
                }
            }

            list.Sort();
            var i = 0;
            var res = new StringBuilder();
            foreach (var item in s)
            {
                var c = item;
                if (vowelSet.Contains(Char.ToLower(item)))
                {
                    c = list[i++];
                }

                res.Append(c);
            }

            return res.ToString();
        }
    }
}

