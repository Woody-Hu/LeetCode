using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class InsertionSortList
    {
        public ListNode InsertionSortListMethod(ListNode head)
        {
            ListNode returnValue = new ListNode(0);

            ListNode tempNode = head;

            while (null != tempNode)
            {
                ListNode iter = returnValue;
                while (iter.next != null && iter.next.val < tempNode.val)
                {
                    iter = iter.next;
                }
                ListNode next = tempNode.next;
                tempNode.next = iter.next;
                iter.next = tempNode;
                tempNode = next;
            }

            return returnValue.next;



        }
    }
}
