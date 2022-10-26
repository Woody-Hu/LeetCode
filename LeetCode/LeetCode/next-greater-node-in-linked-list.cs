using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class next_greater_node_in_linked_list
    {
        public int[] NextLargerNodes(ListNode head)
        {
            var list = new List<int>();
            var cur = head;
            while (cur != null)
            {
                list.Add(cur.val);
                cur = cur.next;
            }

            var stack = new Stack<int>();
            var res = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                while (stack.Any() && list[stack.Peek()] < list[i])
                {
                    var pop = stack.Pop();
                    res[pop] = list[i];
                }

                stack.Push(i);
            }

            return res;
        }
    }
}
