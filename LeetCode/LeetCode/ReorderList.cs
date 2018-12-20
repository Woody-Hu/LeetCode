using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ReorderList
    {
        public void ReorderListMethod(ListNode head)
        {
            if (null == head)
            {
                return;
            }

            var p1 = head;
            var p2 = head;
            while (p2.next != null && p2.next.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
            }

            var preMiddle = p1;
            var preCurrent = p1.next;
            while (preCurrent.next != null)
            {
                var current = preCurrent.next;
                preCurrent.next = current.next;
                current.next = preMiddle.next;
                preMiddle.next = current;
            }

            p1 = head;
            p2 = preMiddle.next;
            while (p1 != preMiddle)
            {
                preMiddle.next = p2.next;
                p2.next = p1.next;
                p1.next = p2;
                p1 = p2.next;
                p2 = preMiddle.next;
            }

        }
    }
}
