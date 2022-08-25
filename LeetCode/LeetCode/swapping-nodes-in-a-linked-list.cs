using System;
namespace LeetCode
{
    public class swapping_nodes_in_a_linked_list
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            var left = head;
            var right = head;
            for (int i = 1; i < k; i++)
            {
                left = left.next;
            }

            var current = left;
            while (current.next != null)
            {
                right = right.next;
                current = current.next;
            }

            var value = right.val;
            right.val = left.val;
            left.val = value;
            return head;
        }
    }
}
