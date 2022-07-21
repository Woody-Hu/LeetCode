using System;
namespace LeetCode
{
    public class minimum_number_of_steps_to_make_two_strings_anagram
    {
        public int MinSteps(string s, string t)
        {
            var sArray = new int[26];
            var tArray = new int[26];
            foreach (var item in s)
            {
                sArray[item - 'a']++;
            }

            foreach (var item in t)
            {
                tArray[item - 'a']++;
            }

            var res = 0;
            for (int i = 0; i < 26; i++)
            {
                if (sArray[i] < tArray[i])
                {
                    res += tArray[i] - sArray[i];
                }
            }

            return res;
        }
    }
}
