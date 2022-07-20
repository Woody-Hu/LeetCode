using System;
namespace LeetCode
{
    public class remove_all_occurrences_of_a_substring
    {
        public string RemoveOccurrences(string s, string part)
        {
            while (s.Contains(part))
            {
                s = s.Substring(0, s.IndexOf(part)) + s.Substring(s.IndexOf(part) + part.Length);
            }

            return s;
        }
    }
}
