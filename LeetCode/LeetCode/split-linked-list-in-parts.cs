using System;
namespace LeetCode
{
	public class split_linked_list_in_parts
	{
		public ListNode[] SplitListToParts(ListNode head, int k)
		{
			var length = 0;
			var temp = head;
            while (temp != null)
            {
				length++;
				temp = temp.next;
            }

			var average = length / k;
			var modRes = length % k;
			var res = new ListNode[k];
			var current = head;
            for (int i = 0; i < k && current != null; i++)
            {
				res[i] = current;
				var useLength = average + (i < modRes ? 1 : 0);
                for (int j = 1; j < useLength; j++)
                {
					current = current.next;
                }

				var next = current.next;
				current.next = null;
				current = next;
            }

			return res;
		}
	}
}

