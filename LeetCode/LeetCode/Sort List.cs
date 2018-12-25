using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Sort_List
    {
        public ListNode SortList(ListNode head)
        {
            if (null == head || head.next == null)
            {
                return head;
            }

            ListNode perNode = null;
            var slowNode = head;
            var fastNode = head;

            while (null != fastNode && null != fastNode.next)
            {
                perNode = slowNode;
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }

            perNode.next = null;

            var headSortedNode = SortList(head);
            var midSortedNode = SortList(slowNode);

            return MergeNodes(headSortedNode, midSortedNode);
        }

        private ListNode MergeNodes(ListNode node1, ListNode node2)
        {
            var tag = new ListNode(-1);
            var current = tag;
            while (null != node1 && null != node2)
            {
                if (node1.val < node2.val)
                {
                    current.next = node1;
                    node1 = node1.next;
                }
                else
                {
                    current.next = node2;
                    node2 = node2.next;
                }

                current = current.next;
            }

            if (null != node1)
            {
                current.next = node1;
            }

            if (null != node2)
            {
                current.next = node2;
            }

            return tag.next;
        }
    }
}
