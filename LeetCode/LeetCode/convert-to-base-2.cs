using System;
using System.Text;

namespace LeetCode
{
	public class convert_to_base_2
	{
        public string BaseNeg2(int n)
        {
            if (n == 0)
            {
                return "0";
            }

            var sb = new StringBuilder();
            while (n != 0)
            {
                var temp = Math.Abs(n) % (-2);
                sb.Append(temp);
                n -= temp;
                n /= -2;
            }

            var sb2 = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                sb2.Append(sb[i]);
            }
            return sb2.ToString();
        }
    }
}

