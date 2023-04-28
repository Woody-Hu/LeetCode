using System;
namespace LeetCode
{
	public class find_the_minimum_and_maximum_number_of_nodes_between_critical_points
	{
        public int[] NodesBetweenCriticalPoints(ListNode head)
        {
            var pre = head;
            var cur = head.next;
            var firstIndex = 0;
            var preIndex = 0;
            var curIndex = 1;
            var min = int.MaxValue;
            var max = -1;
            while (cur.next != null)
            {
                var next = cur.next;
                var less = pre.val > cur.val && next.val > cur.val;
                var great = pre.val < cur.val && next.val < cur.val;
                if (less || great)
                {
                    if (firstIndex == 0)
                    {
                        firstIndex = curIndex;
                    }
                    else
                    {
                        max = curIndex - firstIndex;
                        min = Math.Min(min, curIndex - preIndex);
                    }

                    preIndex = curIndex;
                }

                curIndex++;
                pre = cur;
                cur = next;
            }

            return max == -1 ? new int[] { -1, -1 } : new int[] { min, max };
        }
    }
}

