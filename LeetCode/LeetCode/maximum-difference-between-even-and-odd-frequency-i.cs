using System;
using System.Collections.Generic;

namespace LeetCode;

public class maximum_difference_between_even_and_odd_frequency_i
{
    public int MaxDifference(string s) {
        Dictionary<char, int> c = new Dictionary<char, int>();
        foreach (char ch in s) {
            if (c.ContainsKey(ch)) {
                c[ch]++;
            } else {
                c[ch] = 1;
            }
        }
        int maxOdd = 1, minEven = s.Length;
        foreach (var kvp in c) {
            if (kvp.Value % 2 == 1) {
                maxOdd = Math.Max(maxOdd, kvp.Value);
            } else {
                minEven = Math.Min(minEven, kvp.Value);
            }
        }
        return maxOdd - minEven;
    }
}