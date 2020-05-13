using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Increasing_Decreasing_String
    {
        public string SortString(string s)
        {
            var array = new int[26];
            foreach (var item in s)
            {
                array[item - 'a']++;
            }

            var stringBuilder = new StringBuilder();
            while (stringBuilder.Length < s.Length)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (array[i] > 0)
                    {
                        stringBuilder.Append((char)('a' + i));
                        array[i]--;
                    }
                }

                for (int i = 25; i >=0; i--)
                {
                    if (array[i] > 0)
                    {
                        stringBuilder.Append((char)('a' + i));
                        array[i]--;
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}
