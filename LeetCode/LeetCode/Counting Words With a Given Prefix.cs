using System;
namespace LeetCode
{
    public class Counting_Words_With_a_Given_Prefix
    {
        public int PrefixCount(string[] words, string pref)
        {
            var res = 0;
            foreach (var item in words)
            {
                if (item.Length < pref.Length)
                {
                    continue;
                }

                if (item.StartsWith(pref, StringComparison.Ordinal))
                {
                    res++;
                }
            }

            return res;
        }
    }
}
