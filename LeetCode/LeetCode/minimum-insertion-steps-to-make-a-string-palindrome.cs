using System;

namespace LeetCode;

public class minimum_insertion_steps_to_make_a_string_palindrome
{
    public int MinInsertions(string s) {
        var n = s.Length;
        var dp = new int[n, n];
        for (var i = n - 2; i >= 0; i--) {
            for (var j = i + 1; j < n; j++) {
                dp[i, j] = s[i] == s[j] ? dp[i + 1, j - 1] : Math.Min(dp[i + 1, j], dp[i, j - 1]) + 1;
            }
        }
        
        return dp[0, n - 1];
        
        


    }
}