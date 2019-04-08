using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Remove_Outermost_Parentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            var stringBuilder = new StringBuilder();
            var operationCount = 0;

            foreach (var oneChar in S)
            {
                if (oneChar == '(' && operationCount++ > 0)
                {
                    stringBuilder.Append(oneChar);
                }
                else if (oneChar == ')' && operationCount-- > 1)
                {
                    stringBuilder.Append(oneChar);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
