using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class check_if_digits_are_equal_in_string_after_operations_i
{
    public bool HasSameDigits(string s)
    {
        while (s.Length > 2)
        {
            var rec = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                rec += (int.Parse(s[i].ToString()) + int.Parse(s[i + 1].ToString()))%10;
            }
            
            s = rec;
        }
        
        return s[0] == s[1];
    }

}