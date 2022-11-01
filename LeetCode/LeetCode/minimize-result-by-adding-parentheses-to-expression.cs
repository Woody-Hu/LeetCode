using System;
namespace LeetCode
{
    public class minimize_result_by_adding_parentheses_to_expression
    {
        public string MinimizeResult(string expression)
        {
            var len = expression.Length;
            var plus = expression.IndexOf('+');
            var leftplus = 0;
            var rightplus = 0;
            var leftmul = 1;
            var rightmul = 1;
            for (int i = 0; i < len; i++)
            {
                if (i < plus)
                    leftplus = leftplus * 10 + (expression[i] - '1') + 1;
                if (i > plus)
                    rightplus = rightplus * 10 + (expression[i] - '1') + 1;
            }
            var min = leftmul * (leftplus + rightplus) * rightmul;
            var left = 0;
            var right = len - 1;
            int leftP;
            int rightP;
            for (int i = 0; i < plus; i++)
                for (int j = plus + 1; j < len; j++)
                {
                    leftP = (int)Math.Pow(10, plus - i);
                    rightP = (int)Math.Pow(10, len - 1 - j);
                    leftmul = i == 0 ? 1 : leftplus / leftP;
                    rightmul = j == len - 1 ? 1 : rightplus % rightP;
                    if (leftmul * (leftplus % leftP + rightplus / rightP) * rightmul < min)
                    {
                        min = leftmul * (leftplus % leftP + rightplus / rightP) * rightmul;
                        left = i;
                        right = j;
                    }
                }

            return expression.Remove(left, len - left) + "(" + expression.Remove(right + 1, len - right - 1).Remove(0, left) + ")" + expression.Remove(0, right + 1);
        }
    }
}

