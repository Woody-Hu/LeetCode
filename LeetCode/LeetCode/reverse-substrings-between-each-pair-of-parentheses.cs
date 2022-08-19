using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class reverse_substrings_between_each_pair_of_parentheses
    {
        public string ReverseParentheses(string s)
        {
            var stack = new Stack<string>();
            var stringBuilder = new StringBuilder();
            foreach (var item in s)
            {
                if (item == '(')
                {
                    stack.Push(stringBuilder.ToString());
                    stringBuilder.Length = 0;
                }
                else if (item == ')')
                {
                    var array = stringBuilder.ToString().ToCharArray();
                    stringBuilder.Length = 0;
                    stringBuilder.Append(stack.Pop());
                    for (int i = array.Length - 1; i >=0 ; i--)
                    {
                        stringBuilder.Append(array[i]);
                    }
                }
                else
                {
                    stringBuilder.Append(item);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
