using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Convert_Binary_Number_in_a_Linked_List_to_Integer
    {
        public int GetDecimalValue(ListNode head)
        {
            var stringBuilder = new StringBuilder();
            var current = head;
            while (current != null)
            {
                stringBuilder.Append(current.val);
                current = current.next;
            }

            return Convert.ToInt32(stringBuilder.ToString(), 2);
        }
    }
}
