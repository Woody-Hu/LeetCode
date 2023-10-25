using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class er_cha_shu_de_shen_du_lcof
	{
        public int CalculateDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var res = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var currentSize = queue.Count;
                for (int i = 0; i < currentSize; i++)
                {
                    var current = queue.Dequeue();
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                res++;
            }

            return res;
        }
    }
}

