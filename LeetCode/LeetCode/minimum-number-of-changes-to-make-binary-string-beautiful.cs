using System;
namespace LeetCode
{
	public class minimum_number_of_changes_to_make_binary_string_beautiful
	{
        public int MinChanges(string s)
        {
            var res = 0;
            for (int i = 0; i < s.Length; i = i + 2)
            {
                if (s[i] != s[i + 1])
                {
                    res++;
                }
            }

            return res;
        }
    }
}

