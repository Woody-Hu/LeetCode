using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class bracket_lcci
	{
        public IList<string> GenerateParenthesis(int n)
        {
            var res = new List<string>();
            GenerateInternal(res, new StringBuilder(), 0, 0, n);
            return res;
        }

        private void GenerateInternal(List<string> res, StringBuilder stringBuilder, int open, int close, int max)
        {
            if (stringBuilder.Length == max * 2)
            {
                res.Add(stringBuilder.ToString());
                return;
            }

            if (open < max)
            {
                stringBuilder.Append("(");
                GenerateInternal(res, stringBuilder, open + 1, close, max);
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }

            if (close < open)
            {
                stringBuilder.Append(")");
                GenerateInternal(res, stringBuilder, open, close + 1, max);
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }
        }
    }
}

