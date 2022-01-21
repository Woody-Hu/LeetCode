using System;
using System.Linq;

namespace LeetCode
{
    public class Maximum_Number_of_Words_Found_in_Sentences
    {
        public int MostWordsFound(string[] sentences)
        {
            var res = -1;
            foreach (var item in sentences)
            {
                var current = item.Where(k => k == ' ').Count();
                res = Math.Max(current, res);
            }

            return res + 1;
        }
    }
}
