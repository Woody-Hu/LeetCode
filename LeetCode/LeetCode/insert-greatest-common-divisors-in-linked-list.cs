using System;
namespace LeetCode
{
	public class insert_greatest_common_divisors_in_linked_list
	{
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            var root = head;
            var preValue = head.val;
            var preNode = head;
            head = head.next;
            while (head != null)
            {
                var current = head.val;
                var newValue = CalGCD(preValue, current);
                var newNode = new ListNode(newValue);
                preNode.next = newNode;
                newNode.next = head;
                preValue = current;
                preNode = head;
                head = head.next;
            }

            return root;
        }

        private int CalGCD(int a, int b)
        {
            while (b != 0)
            {
                var r = a % b;
                a = b;
                b = r;
            }

            return a;  
        }
    }
}

