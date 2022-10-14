using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class linked_list_components
    {
        public int NumComponents(ListNode head, int[] nums)
        {
            var res = 0;
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }

            var inSet = false;
            while (head != null)
            {
                if (set.Contains(head.val))
                {
                    if (!inSet)
                    {
                        inSet = true;
                        res++;
                    }
                }
                else
                {
                    inSet = false;
                }

                head = head.next;
            }

            return res;
        }
    }
}
