using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Odd_Even_Linked_List
    {
        public ListNode OddEvenList(ListNode head)
        {
            var cur = head;
            ListNode saved = null;
            ListNode savedCur = null;
            while (cur != null)
            {
                var next = cur.next;
                if (saved != null)
                {
                    savedCur.next = next;
                    savedCur = next;
                }
                else
                {
                    saved = next;
                    savedCur = saved;
                }

                if (next == null)
                {
                    break;
                }

                next = next.next;
                if (next == null)
                {
                    break;
                }

                cur.next = next;
                cur = next;
            }

            if (cur != null)
            {
                cur.next = saved;
            }

            return head;
        }
    }
}
