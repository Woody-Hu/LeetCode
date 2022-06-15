using System;
using System.Linq;

namespace LeetCode
{
    public class percentage_of_letter_in_string
    {
        public int PercentageLetter(string s, char letter)
        {
            var count = s.Count(k => k == letter);
            return count * 100 / s.Length;
        }
    }
}
