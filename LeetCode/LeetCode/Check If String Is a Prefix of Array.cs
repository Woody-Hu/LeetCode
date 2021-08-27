using System;
using System.Text;

namespace LeetCode
{
    public class Check_If_String_Is_a_Prefix_of_Array
    {
        public bool IsPrefixString(string s, string[] words)
        {
            var res = new StringBuilder();
            foreach (var word in words)
            {
                res.Append(word);
                if (s.Equals(res.ToString()))
                    return true;
                if (s.IndexOf(res.ToString()) == -1)
                    return false;
            }

            return false;
        }
    }
}
