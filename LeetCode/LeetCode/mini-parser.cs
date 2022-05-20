using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class mini_parser
    {
        public NestedInteger Deserialize(string s)
        {
            if (!s.StartsWith('['))
            {
                return new NestedInteger(int.Parse(s));
            }

            var stack = new Stack<NestedInteger>();
            var currentValue = 0;
            var isNegitive = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    stack.Push(new NestedInteger());
                }
                else if (s[i] == '-')
                {
                    isNegitive = true;
                }
                else if (char.IsDigit(s[i]))
                {
                    currentValue = currentValue * 10 + s[i] - '0';
                }
                else if (s[i] == ',' || s[i] == ']')
                {
                    if (char.IsDigit(s[i - 1]))
                    {
                        if (isNegitive)
                        {
                            currentValue = -currentValue;
                        }
                        stack.Peek().Add(new NestedInteger(currentValue));
                    }

                    currentValue = 0;
                    isNegitive = false;
                    if (s[i] == ']' && stack.Count > 1)
                    {
                        var lastList = stack.Pop();
                        stack.Peek().Add(lastList);
                    }

                }
            }

            return stack.Pop();
        }

        public class NestedInteger
         {

            // Constructor initializes an empty nested list.
            public NestedInteger()
            { }

            // Constructor initializes a single integer.
            public NestedInteger(int value)
            { }

            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            public bool IsInteger() { return default; }

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            public int GetInteger() { return default; }

            // Set this NestedInteger to hold a single integer.
            public void SetInteger(int value) { }

            // Set this NestedInteger to hold a nested list and adds a nested integer to it.
            public void Add(NestedInteger ni) { }

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            public IList<NestedInteger> GetList() { return default; }
         }
    }
}
