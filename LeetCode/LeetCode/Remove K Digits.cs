using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Remove_K_Digits
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == 0)
                return num;

            if (string.IsNullOrWhiteSpace(num))
                return num;

            var length = num.Length;
            var stack = new Stack<char>();
            for (int i = 0; i < length; i++)
            {
                var current = num[i];
                while (stack.Count > 0 && stack.Peek() > current && k > 0)
                {
                    stack.Pop();
                    k--;
                }

                stack.Push(current);
            }

            while (k > 0 && stack.Count > 0)
            {
                stack.Pop();
                k--;
            }

            var numbers = stack.Reverse().ToList();

            var sb = new StringBuilder();
            var foundNonZero = false;
            foreach (var oneChar in numbers)
            {
                if (!foundNonZero && oneChar == '0')
                {
                    continue;
                }

                foundNonZero = true;
                sb.Append(oneChar);
            }

            return sb.ToString().Length == 0 ? "0" : sb.ToString();
        }
    }
}
