using System.Collections.Generic;

namespace LeetCode;

public class greatest_english_letter_in_upper_and_lower_case
{
    public string GreatestLetter(string s)
    {
        var set = new HashSet<char>();
        foreach (var c in s)
        {
            set.Add(c);
        }
        
        for (var i = 25; i >= 0; i--)
        {
            var upper = (char) ('A' + i);
            var lower = (char) ('a' + i);
            if (set.Contains(upper) && set.Contains(lower))
            {
                return upper.ToString();
            }
        }

        return "";
    }
}