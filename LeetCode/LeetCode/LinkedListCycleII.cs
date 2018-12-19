using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            var set = new HashSet<ListNode>();

            var node = head;
            while (null != node)
            {
                if (null != node.next && set.Contains(node.next))
                {
                    return node.next;
                }

                set.Add(node);
                node = node.next;
            }

            return null;
        }
    }
}
