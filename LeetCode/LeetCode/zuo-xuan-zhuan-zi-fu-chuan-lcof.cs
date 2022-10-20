using System;
using System.Text;

namespace LeetCode
{
    public class zuo_xuan_zhuan_zi_fu_chuan_lcof
    {
        public string ReverseLeftWords(string s, int n)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(s.Substring(n));
            stringBuilder.Append(s.Substring(0, n));
            return stringBuilder.ToString();
        }
    }
}
