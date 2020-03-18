using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Decrypt_String_from_Alphabet_to_Integer_Mapping
    {
        public string FreqAlphabets(string s)
        {
            var stringBuilder = new StringBuilder();
            
            for (int i = 0; i < s.Length; i++)
            {
                int next = 'a' - 1, offset = 0;
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    offset = (s[i++] - '0') * 10 + (s[i++] - '0');
                }
                else
                {
                    offset = s[i] - '0';
                }

                stringBuilder.Append((char)(next + offset));
            }

            return stringBuilder.ToString();
        }
    }
}
