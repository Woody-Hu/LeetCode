using System;
using System.Text;

namespace LeetCode;

public class smallest_palindromic_rearrangement_i
{
    public string SmallestPalindrome(string s)
    {
        var n = s.Length;
        var m = n / 2;
        var t = s.Substring(0, m).ToCharArray();
        Array.Sort(t);
        
        StringBuilder ans = new StringBuilder(n);
        ans.Append(t);
        if (n % 2 > 0) {
            ans.Append(s[m]);
        }
        for (int i = m - 1; i >= 0; i--) {
            ans.Append(t[i]);
        }
        return ans.ToString();
        
    }
}