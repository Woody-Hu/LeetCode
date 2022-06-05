using System;
namespace LeetCode
{
	public class merge_nodes_in_between_zeros
	{
		public ListNode MergeNodes(ListNode head)
		{
			var dummy = new ListNode(0);
			var tail = dummy;
			var currentValue = 0;
			var current = head.next;
            while (current != null)
            {
				if (current.val != 0)
				{
					currentValue += current.val;
				}
				else
				{
					var newNode = new ListNode(currentValue);
					tail.next = newNode;
					tail = newNode;
					currentValue = 0;
				}

				current = current.next;
            }

			return dummy.next;
		}
	}
}

