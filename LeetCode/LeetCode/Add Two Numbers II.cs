using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Add_Two_Numbers_II
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var stack1 = ListNodeToStack(l1);
            var stack2 = ListNodeToStack(l2);
            ListNode cur = null;
            var value = 0;
            while (stack1.Count != 0 && stack2.Count != 0)
            {
                var node1Value = stack1.Pop();
                var node2Value = stack2.Pop();
                var currentValue = node1Value + node2Value + value;
                var nextNode = new ListNode(currentValue % 10);
                nextNode.next = cur;
                cur = nextNode;
                value = currentValue / 10;
            }

            var stack = stack1.Count != 0 ? stack1 : stack2;
            while (stack.Count != 0)
            {
                var nodeValue = stack.Pop();
                var currentValue = nodeValue + value;
                var nextNode = new ListNode(currentValue % 10);
                nextNode.next = cur;
                cur = nextNode;
                value = currentValue / 10;
            }

            while (value != 0)
            {
                var currentValue = value;
                var nextNode = new ListNode(currentValue % 10);
                nextNode.next = cur;
                cur = nextNode;
                value = currentValue / 10;
            }

            return cur;
        }

        private Stack<int> ListNodeToStack(ListNode head)
        {
            var cur = head;
            var stack = new Stack<int>();
            while (cur != null)
            {
                stack.Push(cur.val);
                cur = cur.next;
            }

            return stack;
        }
    }
}
