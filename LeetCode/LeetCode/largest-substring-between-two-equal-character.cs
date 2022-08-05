using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class largest_substring_between_two_equal_character
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var res = -1;
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                var value = s[i] - '0';
                if (dic.ContainsKey(value))
                {
                    res = Math.Max(res, i - dic[value] - 1);
                }
                else
                {
                    dic[value] = i;
                }
            }

            return res;
        }
    }
}

