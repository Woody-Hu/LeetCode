using System;
using System.Text;

namespace LeetCode
{
	public class separate_the_digits_in_an_array
	{
        public int[] SeparateDigits(int[] nums)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in nums)
            {
                stringBuilder.Append(item);
            }

            var length = stringBuilder.Length;
            var res = new int[length];
            var str = stringBuilder.ToString();
            for (int i = 0; i < length; i++)
            {
                res[i] = str[i] - '0';
            }

            return res;
        }
    }
}

