using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class check_if_word_is_valid_after_substitutions
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == 'c')
                {
                    if (!stack.Any() || stack.Pop() != 'b')
                    {
                        return false;
                    }

                    if (!stack.Any() || stack.Pop() != 'a')
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }

            return !stack.Any();
        }
    }
}
