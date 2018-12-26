using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Evaluate_Reverse_Polish_Notation
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var v in tokens)
            {
                if (int.TryParse(v,out var intValue))
                {
                    stack.Push(intValue);
                }
                else
                {
                    var stringValue = v;
                    var value2 = stack.Pop();
                    var value1 = stack.Pop();

                    if (stringValue == "+")
                    {
                        stack.Push(value1 + value2);
                    }
                    else if (stringValue == "-")
                    {
                        stack.Push(value1 - value2);
                    }
                    else if (stringValue == "*")
                    {
                        stack.Push(value1 * value2);
                    }
                    else
                    {
                        stack.Push(value1 / value2);
                    }
                }

            }

            return stack.Pop();
        }
    }
}
