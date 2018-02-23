using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class AddBinary
    {
        public string AddBinaryMethod(string a, string b)
        {
            a = a.Reverse().ToString();
            b = b.Reverse().ToString();
            int maxLen = Math.Max(a.Length, b.Length);
            StringBuilder res = new StringBuilder(maxLen);
            int ia, ib, carry = 0;
            for (int i = 0; i <= maxLen; i++)
            {
                ia = (i < a.Length ? int.Parse(a[i] + string.Empty) : 0);
                ib = (i < b.Length ? int.Parse(b[i] + string.Empty) : 0);
                int sum = ia + ib + carry;
                carry = sum >= 2 ? 1 : 0;
                if (i != maxLen || sum != 0) res.Append(sum % 2);
            }
            return res.ToString().Reverse().ToString();

        }
    }
}
