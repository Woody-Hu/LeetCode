using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode;

public class maximum_length_substring_with_two_occurrences
{
    public int MaximumLengthSubstring(string s)
    {
        var res = 0;
        var length = s.Length;
        for (int i = 0; i < length; i++) {
            for (int j = i; j < length; j++) {
                if (AtMostTwo(s, i, j)) {
                    res = Math.Max(res, j - i + 1);
                }
            }
        }
        
        return res;
    }

    private bool AtMostTwo(string s, int start, int end)
    {
        IDictionary<char, int> counts = new Dictionary<char, int>();
        for (int i = start; i <= end; i++) {
            char c = s[i];
            counts.TryAdd(c, 0);
            counts[c]++;
            if (counts[c] > 2) {
                return false;
            }
        }
        
        return true;
    }
}