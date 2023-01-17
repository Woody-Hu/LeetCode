using System;
using System.Text;

namespace LeetCode
{
    public class smallest_subsequence_of_distinct_characters
    {
        public string SmallestSubsequence(string s)
        {
            var visit = new bool[26];
            var num = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                num[s[i] - 'a']++;
            }

            var stringBuilder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!visit[c - 'a'])
                {
                    while (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] > c)
                    {
                        if (num[stringBuilder[stringBuilder.Length - 1] - 'a'] > 0)
                        {
                            visit[stringBuilder[stringBuilder.Length - 1] - 'a'] = false;
                            stringBuilder.Remove(stringBuilder.Length - 1, 1);
                        }
                        else
                        {
                            break;
                        }
                    }

                    visit[c - 'a'] = true;
                    stringBuilder.Append(c);
                }

                num[c - 'a'] -= 1;
            }

            return stringBuilder.ToString();
        }
    }
}
