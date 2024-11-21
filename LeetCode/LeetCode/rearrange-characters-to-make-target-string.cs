using System;
using System.Collections.Generic;

namespace LeetCode;

public class rearrange_characters_to_make_target_string
{
    public int RearrangeCharacters(string s, string target) {
        var sCounts = new Dictionary<char, int>();
        var targetCounts = new Dictionary<char, int>();
        foreach (char c in target) {
            targetCounts.TryAdd(c, 0);
            targetCounts[c]++;
        }
        foreach (char c in s) {
            if (targetCounts.ContainsKey(c)) {
                sCounts.TryAdd(c, 0);
                sCounts[c]++;
            }
        }
        
        var ans = int.MaxValue;
        foreach (var pair in targetCounts) {
            var c = pair.Key;
            var count = pair.Value;
            var totalCount = sCounts.ContainsKey(c) ? sCounts[c] : 0;
            ans = Math.Min(ans, totalCount / count);
            if (ans == 0) {
                return 0;
            }
        }
        
        return ans;
    }
}