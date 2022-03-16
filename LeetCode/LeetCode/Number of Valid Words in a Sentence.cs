using System;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public class Number_of_Valid_Words_in_a_Sentence
    {
        public int CountValidWords(string sentence)
        {
            var regex1 = new System.Text.RegularExpressions.Regex("^([a-z]+(-?[a-z]+)?)?(!|\\.|,)?$");
            var regex2 = new System.Text.RegularExpressions.Regex("[^0-9]+");
            var items = sentence.Split(' ');
            var res = 0;
            foreach (var item in items)
            {
                if (regex1.IsMatch(item) && regex2.IsMatch(item))
                {
                    res++;
                }
            }

            return res;
        }
    }
}
