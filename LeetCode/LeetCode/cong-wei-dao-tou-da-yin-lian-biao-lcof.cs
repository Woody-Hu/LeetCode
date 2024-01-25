using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class cong_wei_dao_tou_da_yin_lian_biao_lcof
	{
        public int[] ReverseBookList(ListNode head)
        {
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            list.Reverse();
            return list.ToArray();
        }
    }
}

