using System;
namespace LeetCode
{
    public class minimum_number_of_steps_to_make_two_strings_anagram_ii
    {
        public int MinSteps(string s, string t)
        {
            var diff = new int[26];
            foreach (var item in s)
            {
                diff[item - 'a']++;
            }

            foreach (var item in t)
            {
                diff[item - 'a']--;
            }

            var res = 0;
            foreach (var item in diff)
            {
                res += Math.Abs(item);
            }

            return res;
        }
    }
}
