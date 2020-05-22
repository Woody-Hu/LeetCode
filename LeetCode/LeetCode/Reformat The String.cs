using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Reformat_The_String
    {
        public string Reformat(string s)
        {
            var letterStack = new Stack<char>();
            var digitStack = new Stack<char>();
            foreach (var oneChar in s)
            {
                if (Char.IsDigit(oneChar))
                {
                    digitStack.Push(oneChar);
                }
                else
                {
                    letterStack.Push(oneChar);
                }
            }

            var res = new StringBuilder();
            var longStack = letterStack;
            var lowStack = digitStack;
            if (digitStack.Count > letterStack.Count)
            {
                longStack = digitStack;
                lowStack = letterStack;
            }

            if ((longStack.Count - lowStack.Count) > 1)
            {
                return res.ToString();
            }

            while (longStack.Any() && lowStack.Any())
            {
                res.Append(longStack.Pop());
                res.Append(lowStack.Pop());
            }

            if (longStack.Any())
            {
                res.Append(longStack.Pop());
            }

            return res.ToString();
        }
    }
}
