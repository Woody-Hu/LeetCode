using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinStack
    {
        private long minValue;

        private Stack<long> thisStack;

        /** initialize your data structure here. */
        public MinStack()
        {
            thisStack = new Stack<long>();
        }

        public void Push(int x)
        {
            if (0 == thisStack.Count)
            {
                minValue = x;
            }
            thisStack.Push(x - minValue);
            if (x < minValue)
            {
                minValue = x;
            }
        }

        public void Pop()
        {
            if (thisStack.Count == 0)
            {
                return;
            }

            long popValue = thisStack.Pop();
            if (popValue < 0)
            {
                minValue = minValue - popValue;
            }
        }

        public int Top()
        {
            long returnValue = thisStack.Peek();
            if (returnValue > 0)
            {
                returnValue = returnValue + minValue;
            }
            else
            {
                returnValue = minValue;
            }
            return (int)returnValue;
        }

        public int GetMin()
        {
            return (int)minValue;
        }
    }
}
