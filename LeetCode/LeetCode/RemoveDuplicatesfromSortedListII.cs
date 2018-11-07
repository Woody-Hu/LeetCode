using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RemoveDuplicatesfromSortedListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode useTag = new ListNode(-1);

            useTag.next = head;

            ListNode frontNode = useTag;

            ListNode nowNode = head;

            int? duplicateValue = null;

            while (null != nowNode)
            {
                var nextNode = nowNode.next;

                if (null != nextNode && nowNode.val == nextNode.val)
                {
                    if (null == duplicateValue)
                    {
                        duplicateValue = nowNode.val;
                    }
                    nowNode = nextNode;
                    continue;
                }

                if (null != duplicateValue)
                {
                    duplicateValue = null;
                    nowNode = nextNode;
                    frontNode.next = nowNode;
                    continue;
                }

                frontNode.next = nowNode;

                frontNode = nowNode;

                nowNode = nowNode.next;
            }

            return useTag.next;

        }
    }
}
