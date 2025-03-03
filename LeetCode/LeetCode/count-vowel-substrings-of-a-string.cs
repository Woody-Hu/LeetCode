using System.Collections.Generic;

namespace LeetCode;

public class count_vowel_substrings_of_a_string
{
    public int CountVowelSubstrings(string word) {
        var res = 0;
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
        var n = word.Length;
        for (int i = 0; i < n; i++)
        {
            var tempSet = new HashSet<char>();
            for (int j = i; j < n; j++)
            {
                tempSet.Add(word[j]);
                if (tempSet.SetEquals(vowels))
                {
                    res++;
                }
            }
        }

        return res;

    }
}