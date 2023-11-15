using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class special_binary_string
	{
        public string MakeLargestSpecial(string s)
        {
            if (s.Length <= 2)
            {
                return s;
            }

            var cnt = 0;
            var left = 0;
            var subs = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    ++cnt;
                }
                else
                {
                    --cnt;
                    if (cnt == 0)
                    {
                        subs.Add("1" + MakeLargestSpecial(s.Substring(left + 1, i - left - 1)) + '0');
                        left = i + 1;
                    }
                }
            }

            subs.Sort((a, b) => b.CompareTo(a));
            var stringBuilder = new StringBuilder();
            foreach (var item in subs)
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }
    }
}

