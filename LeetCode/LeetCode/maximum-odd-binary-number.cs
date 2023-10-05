using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class maximum_odd_binary_number
	{
        public string MaximumOddBinaryNumber(string s)
        {
            var count1 = s.Where(c => c == '1').Count();
            var pre = count1 - 1;
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < pre; i++)
            {
                stringBuilder.Append("1");
            }

            for (int i = 0; i < s.Length - count1; i++)
            {
                stringBuilder.Append("0");
            }

            stringBuilder.Append("1");
            return stringBuilder.ToString();

        }
    }
}

