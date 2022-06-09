using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class sum_of_nodes_with_even_valued_grandparent
    {
        public int SumEvenGrandparent(TreeNode root)
        {
            var res = 0;
            if (root == null)
            {
                return res;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (node.val % 2 == 0)
                {
                    if (node.left?.left != null)
                    {
                        res += node.left.left.val;
                    }

                    if (node.left?.right != null)
                    {
                        res += node.left.right.val;
                    }

                    if (node.right?.left != null)
                    {
                        res += node.right.left.val;
                    }

                    if (node.right?.right != null)
                    {
                        res += node.right.right.val;
                    }
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            return res;
        }
    }
}
