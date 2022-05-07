using System;
namespace LeetCode
{
	public class plus_one_linked_list
	{
		public ListNode PlusOne(ListNode head)
		{
			var sentiel = new ListNode(0);
			sentiel.next = head;
			var find = sentiel;
            while (head != null)
            {
                if (head.val != 9)
                {
					find = head;
                }

				head = head.next;
            }

			find.val = find.val + 1;
			find = find.next;
            while (find != null)
            {
				find.val = 0;
				find = find.next;
            }

            if (sentiel.val == 0)
            {
				return sentiel.next;
            }

			return sentiel;
		}
	}
}

