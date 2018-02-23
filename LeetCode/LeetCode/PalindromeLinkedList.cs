using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (null == head)
            {
                return true;
            }

            ListNode fast = head;
            ListNode mid = head.next;
            ListNode slow = head;

            ListNode tempNode = null;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                tempNode = slow;
                slow = mid;
                mid = mid.next;
  
                slow.next = tempNode;
            }

            if (fast.next == null)
            {
                slow = slow.next;
            }

            while (mid != null)
            {
                if (slow.val != mid.val)
                {
                    return false;
                }

                slow = slow.next;
                mid = mid.next;
            }

            return true;


        }
    }


}
