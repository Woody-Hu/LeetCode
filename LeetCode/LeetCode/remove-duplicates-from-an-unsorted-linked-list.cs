using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class remove_duplicates_from_an_unsorted_linked_list
    {
        public ListNode DeleteDuplicatesUnsorted(ListNode head)
        {
            var resHead = new ListNode(0);
            resHead.next = head;
            var current = head;
            var dic = new Dictionary<int, int>();
            while (current != null)
            {
                if (!dic.ContainsKey(current.val))
                {
                    dic.Add(current.val, 0);
                }

                dic[current.val]++;
                current = current.next;
            }

            current = head;
            var pre = resHead;
            while (current != null)
            {
                if (dic[current.val] > 1)
                {
                    pre.next = current.next;
                }
                else
                {
                    pre = pre.next;
                }

                current = current.next;
            }

            return resHead.next;
        }
    }
}
