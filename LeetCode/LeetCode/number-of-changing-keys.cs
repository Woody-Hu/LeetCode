using System;
namespace LeetCode
{
	public class number_of_changing_keys
	{
        public int CountKeyChanges(string s)
        {
            var res = 0;
            var pre = Char.ToLower(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                var cur = Char.ToLower(s[i]);
                if (cur != pre)
                {
                    res++;
                }

                pre = cur;
            }

            return res;
        }
    }
}

