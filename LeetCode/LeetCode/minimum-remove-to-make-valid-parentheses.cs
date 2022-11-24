using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class minimum_remove_to_make_valid_parentheses
    {
        public string MinRemoveToMakeValid(string s)
        {
            var stack = new Stack<int>();
            var res = new StringBuilder();
            var array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(')
                {
                    stack.Push(i);
                }
                else if (array[i] == ')')
                {
                    if (!stack.Any())
                    {
                        array[i] = '1';
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            while (stack.Any())
            {
                array[stack.Pop()] = '1';
            }

            foreach (var item in array)
            {
                if (item != '1')
                {
                    res.Append(item);
                }
            }

            return res.ToString();
        }
    }
}
