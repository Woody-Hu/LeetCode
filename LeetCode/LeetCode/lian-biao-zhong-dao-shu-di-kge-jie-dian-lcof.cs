using System;
namespace LeetCode
{
	public class lian_biao_zhong_dao_shu_di_kge_jie_dian_lcof
	{
        public ListNode TrainingPlan(ListNode head, int cnt)
        {
            var front = head;
            var back = head;
            for (int i = 0; i < cnt; i++)
            {
                front = front.next;
            }

            while (front != null)
            {
                front = front.next;
                back = back.next;
            }

            return back;
        }
    }
}

