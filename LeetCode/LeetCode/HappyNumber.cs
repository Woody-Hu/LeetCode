using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class HappyNumber
    {
        public bool IsHappy(int n)
        {
            if (n < 1)
                return false;
            if (n == 1)
                return true;

            List<int> lstHaveValue = new List<int>();

            while (true)
            {
                int s = 0;

                while (n >= 1)
                {
                    s = s + (n % 10) * (n % 10);
                    n = n / 10;
                }

                if (1 == s)
                {
                    return true;
                }

                if (lstHaveValue.Contains(s))
                {
                    return false;
                }
                else
                {
                    lstHaveValue.Add(s);
                }

                n = s;
            }

        }
    }
}
