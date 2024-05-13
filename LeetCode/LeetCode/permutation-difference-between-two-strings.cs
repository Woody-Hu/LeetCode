using System;

namespace LeetCode;

public class permutation_difference_between_two_strings
{
    public int FindPermutationDifference(string s, string t) {
        var pos = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            pos[s[i] - 'a'] = i;
        }
        
        var res = 0;
        for (int i = 0; i < t.Length; i++)
        {
            res += Math.Abs(pos[t[i] - 'a'] - i);
        }
        
        return res;
    }
}