using System;
using System.Text;

namespace LeetCode
{
    public class ThousandSeparator
    {
        public ThousandSeparator()
        {
        }

        public string ThousandSeparatorMethod(int n)
        {
            var s = n.ToString();
            var b = new StringBuilder();

            int j = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (j == 3)
                {
                    b.Insert(0, ".");
                    j = 0;
                }
                b.Insert(0, s[i]);
                j++;
            }

            return b.ToString();
        }
    }
}
