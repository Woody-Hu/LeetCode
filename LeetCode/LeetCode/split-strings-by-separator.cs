using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class split_strings_by_separator
	{
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            var res = new List<string>(words.Count);
            foreach (var item in words)
            {
                var splited = item.Split(separator);
                foreach (var subStr in splited)
                {
                    if (!string.IsNullOrWhiteSpace(subStr))
                    {
                        res.Add(subStr);
                    }
                }
            }

            return res;
        }
    }
}

