using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IDBivT
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var res = new List<string>();
            var stringBuilder = new StringBuilder();
            GenerateParenthesisInternal(res, stringBuilder, 0, 0, n);
            return res;
        }

        private void GenerateParenthesisInternal(IList<string> res, StringBuilder stringBuilder, int open, int close, int n)
        {
            if (stringBuilder.Length == 2*n)
            {
                res.Add(stringBuilder.ToString());
            }

            if (open < n)
            {
                stringBuilder.Append('(');
                GenerateParenthesisInternal(res, stringBuilder, open + 1, close, n);
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }

            if (close < open)
            {
                stringBuilder.Append(')');
                GenerateParenthesisInternal(res, stringBuilder, open, close + 1, n);
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }
        }
    }
}
