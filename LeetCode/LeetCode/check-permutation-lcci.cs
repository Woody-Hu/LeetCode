using System;

namespace LeetCode;

public class check_permutation_lcci
{
    public bool CheckPermutation(string s1, string s2) {
        if (s1.Length != s2.Length) {
            return false; 
        }
        
        var str1 = s1.ToCharArray();
        var str2 = s2.ToCharArray();
        Array.Sort(str1);
        Array.Sort(str2);
        for (int i = 0; i < str1.Length; i++) {
            if (str1[i] != str2[i]) {
                return false; 
            }
        }

        return true;


    }
}