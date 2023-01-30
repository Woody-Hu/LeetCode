using System;
using System.Text;

namespace LeetCode
{
    public class smallest_string_with_a_given_numeric_value
    {
        public string GetSmallestString(int n, int k)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                var temp = Math.Max(1, k - (n - i) * 26);
                k -= temp;
                stringBuilder.Append((char)('a' + temp - 1));
            }

            return stringBuilder.ToString();
        }
    }
}
