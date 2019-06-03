using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Greatest_Common_Divisor_of_Strings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            { return GcdOfStrings(str2, str1); } 
            else if (!str1.StartsWith(str2))
            { return ""; } 
            else if (string.IsNullOrEmpty(str2))
            { return str1; } 
            else
            { return GcdOfStrings(str1.Substring(str2.Length), str2); } 
        }
    }
}
