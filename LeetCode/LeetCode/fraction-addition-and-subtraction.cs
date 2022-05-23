using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class fraction_addition_and_subtraction
    {
        public string FractionAddition(string expression)
        {
            int maxDen = 9 * 8 * 7 * 5;
            var numList = new List<int>();
            int r = expression.Length - 1;
            int mult = 1;
            for (int i = expression.Length - 1; i >= 0; i--)
            {
                char c = expression[i];
                switch (c)
                {
                    case '-':
                        numList.Add(-int.Parse(expression.Substring(i + 1, r - i)) * mult);
                        r = i - 1;
                        break;
                    case '/':
                        mult = maxDen / int.Parse(expression.Substring(i + 1, r - i));
                        r = i - 1;
                        break;
                    case '+':
                        numList.Add(int.Parse(expression.Substring(i + 1, r - i)) * mult);
                        r = i - 1;
                        break;
                    default:
                        break;
                }
            }
            if (r >= 0)
            {
                numList.Add(int.Parse(expression.Substring(0, r + 1)) * mult);
            }
            int num = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                num += numList[i];
            }
            int gcd(int a, int b)
            {
                if (b == 0)
                {
                    return a;
                }
                return gcd(b, a % b);
            }

            int maxMult = gcd(Math.Abs(num), maxDen);
            num = num / maxMult;
            maxDen = maxDen / maxMult;
            return string.Format("{0}/{1}", num, maxDen);
        }
    }
}
