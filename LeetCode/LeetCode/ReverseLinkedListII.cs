using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode tag = new ListNode(-1);
            tag.next = head;
            ListNode[] useArray = new ListNode[n-m+1];
            ListNode frontNode = null;
            ListNode currentNode = tag;
            int index = 0;

            while (null != currentNode)
            {
                if (index == m-1)
                {
                    frontNode = currentNode;
                }
                else if (index >= m && index <= n)
                {
                    useArray[index - m] = currentNode;
                }
                else if (index > n)
                {
                    break;
                }

                currentNode = currentNode.next;
                index++;
            }

            if (null != frontNode)
            {
                var rearNode = useArray[n - m].next;
                currentNode = frontNode;

                for (int i = n - m; i >=0; i--)
                {
                    currentNode.next = useArray[i];
                    currentNode = currentNode.next;
                }

                currentNode.next = rearNode;
            }

            return tag.next;
        }
    }
}
