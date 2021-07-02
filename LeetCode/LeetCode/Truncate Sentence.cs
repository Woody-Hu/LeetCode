using System;
using System.Text;

namespace LeetCode
{
    public class Truncate_Sentence
    {
        public string TruncateSentence(string s, int k)
        {
            var splited = s.Split(' ');
            if (k >= splited.Length)
            {
                return s;
            }

            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= k; i++)
            {
                if (i != 1)
                {
                    stringBuilder.Append(" ");
                }

                stringBuilder.Append(splited[i - 1]);
            }

            return stringBuilder.ToString();
        }
    }
}
