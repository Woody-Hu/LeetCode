using System.Collections.Generic;
using System.Text;

namespace LeetCode;

public class parse_lisp_expression
{
    Dictionary<string, Stack<int>> scope = new Dictionary<string, Stack<int>>();
    int start = 0;

    public int Evaluate(string expression) {
        return InnerEvaluate(expression);
    }

    public int InnerEvaluate(string expression) {
        if (expression[start] != '(') {
            if (char.IsLower(expression[start])) {
                string var = ParseVar(expression);
                return scope[var].Peek();
            } else {
                return ParseInt(expression);
            }
        }
        int ret;
        start++;
        if (expression[start] == 'l') {
            start += 4;
            IList<string> vars = new List<string>();
            while (true) {
                if (!char.IsLower(expression[start])) {
                    ret = InnerEvaluate(expression);
                    break;
                }
                string var = ParseVar(expression);
                if (expression[start] == ')') {
                    ret = scope[var].Peek();
                    break;
                }
                vars.Add(var);
                start++;
                int e = InnerEvaluate(expression);
                if (!scope.ContainsKey(var)) {
                    scope.Add(var, new Stack<int>());
                }
                scope[var].Push(e);
                start++;
            }
            foreach (string var in vars) {
                scope[var].Pop();
            }
        } else if (expression[start] == 'a') {
            start += 4;
            int e1 = InnerEvaluate(expression);
            start++;
            int e2 = InnerEvaluate(expression);
            ret = e1 + e2;
        } else {
            start += 5;
            int e1 = InnerEvaluate(expression);
            start++;
            int e2 = InnerEvaluate(expression);
            ret = e1 * e2;
        }
        start++;
        return ret;
    }

    public int ParseInt(string expression) {
        int n = expression.Length;
        int ret = 0, sign = 1;
        if (expression[start] == '-') {
            sign = -1;
            start++;
        }
        while (start < n && char.IsDigit(expression[start])) {
            ret = ret * 10 + (expression[start] - '0');
            start++;
        }
        return sign * ret;
    }

    public string ParseVar(string expression) {
        int n = expression.Length;
        StringBuilder ret = new StringBuilder();
        while (start < n && expression[start] != ' ' && expression[start] != ')') {
            ret.Append(expression[start]);
            start++;
        }
        return ret.ToString();
    }
}