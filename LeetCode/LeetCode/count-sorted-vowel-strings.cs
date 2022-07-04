using System;
namespace LeetCode
{
    public class count_sorted_vowel_strings
    {
        public int CountVowelStrings(int n)
        {
            return (n + 4) * (n + 3) * (n + 2) * (n + 1) / 24;
        }
    }
}
