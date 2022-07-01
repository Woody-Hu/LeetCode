using System;
namespace LeetCode
{
    public class delete_middle_node_lcci
    {
        public void DeleteNode(ListNode node)
        {
            var next = node.next;
            node.val = next.val;
            node.next = next.next;
        }
    }
}
