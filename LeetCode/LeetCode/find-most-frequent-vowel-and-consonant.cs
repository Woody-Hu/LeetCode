using System;
using System.Collections.Generic;

namespace LeetCode;

public class find_most_frequent_vowel_and_consonant
{
    public int MaxFreqSum(string s) {
        IDictionary<char, int> counts = new Dictionary<char, int>();
        foreach (char c in s) {
            counts.TryAdd(c, 0);
            counts[c]++;
        }
        int maxVowel = 0, maxConsonant = 0;
        foreach (KeyValuePair<char, int> pair in counts) {
            char c = pair.Key;
            int count = pair.Value;
            if (IsVowel(c)) {
                maxVowel = Math.Max(maxVowel, count);
            } else {
                maxConsonant = Math.Max(maxConsonant, count);
            }
        }
        return maxVowel + maxConsonant;
    }

    public bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}