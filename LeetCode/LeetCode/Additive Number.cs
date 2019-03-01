using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Additive_Number
    {
        public bool IsAdditiveNumber(string num)
        {
            if (num.Length < 3)
            {
                return false;
            }

            return IsAdditiveNumber(num, -1, -1, 0);
        }

        private bool IsAdditiveNumber(string num, long first, long second, int index)
        {
            if (first > -1 && second >-1)
            {
                var str = (first + second).ToString();
                if (!num.Substring(index).StartsWith(str))
                {
                    return false;
                }

                if (num.Substring(index).StartsWith(str) && index + str.Length == num.Length)
                {
                    return true;
                }
            }

            first = second;
            var result = false;
            for (int i = 1; i < num.Length - index; i++)
            {
                var str = num.Substring(index, i);
                if (str.Length > 1 && str[0] == '0') continue;
                result |= IsAdditiveNumber(num, first, long.Parse(str), index + i);
                if (result) break;
            }

            return result;
        }
    }
}
