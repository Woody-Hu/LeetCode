using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MiddleoftheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            List<ListNode> returnValue = new List<ListNode>();

            ListNode tempNode = head;

            while (null != tempNode)
            {
                returnValue.Add(tempNode);
                tempNode = tempNode.next;
            }

            return returnValue[returnValue.Count / 2];
        }
    }
}
