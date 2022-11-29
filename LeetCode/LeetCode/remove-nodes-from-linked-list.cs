using System;
namespace LeetCode
{
    public class remove_nodes_from_linked_list
    {
        public ListNode RemoveNodes(ListNode head)
        {
            return RemoveNodesInternal(head);
        }

        private ListNode RemoveNodesInternal(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            head.next = RemoveNodesInternal(head.next);
            if (head.val < head.next.val)
            {
                return head.next;
            }

            return head;

        }
    }
}
