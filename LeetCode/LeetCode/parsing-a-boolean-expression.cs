using System.Collections.Generic;

namespace LeetCode;

public class parsing_a_boolean_expression
{
    public bool ParseBoolExpr(string expression) {
        var stack = new Stack<char>();
        var n = expression.Length;
        for (var i = 0; i < n; i++) {
            var c = expression[i];
            if (c == ',') {
                continue;
            } else if (c != ')') {
                stack.Push(c);
            } else {
                int t = 0, f = 0;
                while (stack.Peek() != '(') {
                    var val = stack.Pop();
                    if (val == 't') {
                        t++;
                    } else {
                        f++;
                    }
                }
                stack.Pop();
                var op = stack.Pop();
                switch (op) {
                    case '!':
                        stack.Push(f == 1 ? 't' : 'f');
                        break;
                    case '&':
                        stack.Push(f == 0 ? 't' : 'f');
                        break;
                    case '|':
                        stack.Push(t > 0 ? 't' : 'f');
                        break;
                    default:
                        break;
                }
            }
        }
        
        return stack.Pop() == 't';
    }
}