using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class list_of_depth_lcci
    {
        public ListNode[] ListOfDepth(TreeNode tree)
        {
            var list = new List<ListNode>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree);
            while (queue.Any())
            {
                var size = queue.Count();
                var dummy = new ListNode(0);
                var head = dummy;
                while (size-- >0)
                {
                    var node = queue.Dequeue();
                    head.next = new ListNode(node.val);
                    head = head.next;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                list.Add(dummy.next);
            }

            return list.ToArray();
        }

        
    }
}
