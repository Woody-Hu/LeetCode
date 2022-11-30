using System;
namespace LeetCode
{
	public class append_characters_to_string_to_make_subsequenc
	{
        public int AppendCharacters(string s, string t)
        {
            var p = 0;
            foreach (var item in s)
            {
                if (item == t[p])
                {
                    p++;
                }

                if (p == t.Length)
                {
                    break;
                }
            }

            return t.Length - p;
        }
    }
}

