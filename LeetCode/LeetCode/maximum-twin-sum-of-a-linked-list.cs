using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_twin_sum_of_a_linked_list
    {
        public int PairSum(ListNode head)
        {
            var slow = head;
            var fast = slow.next;
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var revert = RevertListNode(slow);
            var next = head;
            var res = 0;
            while (revert != null && next != null)
            {
                res = Math.Max(res, revert.val + next.val);
                revert = revert.next;
                next = next.next;
            }

            return res;
        }

        private ListNode RevertListNode(ListNode lowNode)
        {
            ListNode preNode = null;
            ListNode temp = null;

            while (lowNode != null)
            {
                temp = lowNode.next;

                lowNode.next = preNode;
                preNode = lowNode;

                lowNode = temp;
            }

            return preNode;
        }
    }
}
