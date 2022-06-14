using System;
namespace LeetCode
{
    public class merge_in_between_linked_lists
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            var pre1 = list1;
            var pos1 = list1;
            var pos2 = list2;
            int i = 0, j = 0;
            while (pre1 != null && pos1 != null && j < b)
            {
                if (i != a - 1)
                {
                    pre1 = pre1.next;
                    i++;
                }

                if (j != b)
                {
                    pos1 = pos1.next;
                    j++;
                }
            }

            while (pos2.next != null)
            {
                pos2 = pos2.next;
            }

            pos1 = pos1.next;
            pre1.next = list2;
            pos2.next = pos1;
            return list1;
        }
    }
}
