using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Flatten_Nested_List_Iterator
    {
        private Stack<NestedInteger> _stack = new Stack<NestedInteger>();
        public Flatten_Nested_List_Iterator(IList<NestedInteger> nestedList)
        {
            for (int i = nestedList.Count -1; i >=0; i--)
            {
                _stack.Push(nestedList[i]);
            }
        }

        public bool HasNext()
        {
            while (_stack.Count != 0)
            {
                var current = _stack.Peek();
                if (current.IsInteger())
                {
                    return true;
                }
                _stack.Pop();
                for (int i = current.GetList().Count - 1; i >= 0; i--)
                {
                    _stack.Push(current.GetList()[i]);
                }
            }

            return false;
        }

        public int Next()
        {
            return _stack.Pop().GetInteger();
        }
    }


     // This is the interface that allows for creating nested lists.
     // You should not implement it, or speculate about its implementation
     interface NestedInteger
     {

         // @return true if this NestedInteger holds a single integer, rather than a nested list.
         bool IsInteger();

         // @return the single integer that this NestedInteger holds, if it holds a single integer
         // Return null if this NestedInteger holds a nested list
         int GetInteger();

         // @return the nested list that this NestedInteger holds, if it holds a nested list
         // Return null if this NestedInteger holds a single integer
         IList<NestedInteger> GetList();
     }
}
