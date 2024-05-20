using System;

namespace LeetCode;

public class check_whether_two_strings_are_almost_equivalent
{
    public bool CheckAlmostEquivalent(string word1, string word2)
    {
        var dic1 = new int[26];
        var dic2 = new int[26];
        var n = word1.Length;
        for (int i = 0; i < n; i++)
        {
            var c1 = word1[i] - 'a';
            var c2 = word2[i] - 'a';
            dic1[c1]++;
            dic2[c2]++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (Math.Abs(dic1[i] - dic2[i]) > 3)
            {
                return false;
            }
        }

        return true;


    }
}