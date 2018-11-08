using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode tagNode = new ListNode(-1);

            ListNode leftNode = tagNode;
            ListNode rightNode = head;
            ListNode currentNode = head;
            ListNode frontNode = tagNode;

            tagNode.next = head;

            while (null != currentNode && currentNode.val < x)
            {
                leftNode = currentNode;
                currentNode = currentNode.next;
            }

            rightNode = currentNode;
            frontNode = leftNode;

            while (null != currentNode)
            {
                if (currentNode.val < x)
                {
                    frontNode.next = currentNode.next;
                    leftNode.next = currentNode;
                    leftNode = leftNode.next;
                }
                else
                {
                    frontNode = currentNode;
                }

                currentNode = currentNode.next;
            }

            leftNode.next = rightNode;

            return tagNode.next;

        }
    }
}
