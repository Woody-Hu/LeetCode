using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class maximum_level_sum_of_a_binary_tree
    {
        public int MaxLevelSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<TreeNode>();
            var max = int.MinValue;
            var deep = 1;
            var res = 1;
            queue.Enqueue(root);
            while (queue.Any())
            {
                var count = queue.Count;
                var sum = 0;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    sum += node.val;
                }

                if (sum > max)
                {
                    max = sum;
                    res = deep;
                }

                deep++;
            }

            return res;
        }
    }
}
