using System;
using System.Collections.Generic;

namespace LeetCode;

public class count_substrings_with_k_frequency_characters_i
{
    public int NumberOfSubstrings(string s, int k) {
        int substrings = 0;
        int length = s.Length;
        int minEnd = 0;
        for (int i = 0; i < length && minEnd != int.MaxValue; i++) {
            minEnd = int.MaxValue;
            IDictionary<char, int> counts = new Dictionary<char, int>();
            for (int j = i; j < length && minEnd >= length; j++) {
                char c = s[j];
                counts.TryAdd(c, 0);
                counts[c]++;
                if (counts[c] == k) {
                    minEnd = j;
                }
            }
            substrings += Math.Max(length - minEnd, 0);
        }
        return substrings;
    }
}