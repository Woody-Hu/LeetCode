using System;
namespace LeetCode
{
    public class Reverse_Words_in_a_String_II
    {
        public void ReverseWords(char[] s)
        {
            Revert(s, 0, s.Length -1);
            var start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    Revert(s, start, i - 1);
                    start = i + 1;
                }
            }

            Revert(s, start, s.Length - 1);
        }

        private void Revert(char[] s, int start, int end)
        {
            while (start < end)
            {
                var temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
        }
    }
}
