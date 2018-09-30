using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (null == head|| null == head.next)
            {
                return head;
            }

            int useLegth = 0;

            var tempIndex = head;


            while (null != tempIndex)
            {
                tempIndex = tempIndex.next;
                useLegth++;
            }

            ListNode curr = head;
            for (int i = 0; i < k%useLegth; i++)
            {
                ListNode x = curr;
                ListNode prev = new ListNode(-1);
                prev.next = curr;

                while (curr.next != null)
                {
                    curr = curr.next;
                    prev = prev.next;
                }
                prev.next = null;
                curr.next = x;
            }

            return curr;



        }
    }
}
