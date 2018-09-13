using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char,int> useDic = new Dictionary<char, int>();
            int nowCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (useDic.ContainsKey(s[i]))
                {
                    nowCount = Math.Max(nowCount, useDic.Count);
                    i = useDic[s[i]];
                    useDic = new Dictionary<char, int>();
                }
                else
                {
                    useDic.Add(s[i],i);
                }
            }

            nowCount = Math.Max(nowCount, useDic.Count);

            return nowCount;
        }
    }
}
