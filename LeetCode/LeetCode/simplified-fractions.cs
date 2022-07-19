using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class simplified_fractions
    {
        public IList<string> SimplifiedFractions(int n)
        {
            var ans = new List<string>();
            for (int denominator = 2; denominator <= n; ++denominator)
            {
                for (int numerator = 1; numerator < denominator; ++numerator)
                {
                    if (Calculate(numerator, denominator) == 1)
                    {
                        ans.Add(numerator + "/" + denominator);
                    }
                }
            }

            return ans;
        }

        private int Calculate(int a, int b)
        {
            return b != 0 ? Calculate(b, a % b) : a;
        }
    }
}
