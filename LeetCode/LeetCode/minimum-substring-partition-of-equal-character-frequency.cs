using System;
using System.Collections.Generic;

namespace LeetCode;

public class minimum_substring_partition_of_equal_character_frequency
{
    const int INF = 0x3f3f3f3f;

    public int MinimumSubstringsInPartition(string s) {
        int n = s.Length;
        int[] d = new int[n + 1];
        Array.Fill(d, INF);
        d[0] = 0;
        for (int i = 1; i <= n; i++) {
            IDictionary<char, int> occCnt = new Dictionary<char, int>();
            int maxCnt = 0;
            for (int j = i; j >= 1; j--) {
                occCnt.TryAdd(s[j - 1], 0);
                occCnt[s[j - 1]]++;
                maxCnt = Math.Max(maxCnt, occCnt[s[j - 1]]);
                if (maxCnt * occCnt.Count == (i - j + 1) && d[j - 1] != INF) {
                    d[i] = Math.Min(d[i], d[j - 1] + 1);
                }
            }
        }
        return d[n];
    }
}