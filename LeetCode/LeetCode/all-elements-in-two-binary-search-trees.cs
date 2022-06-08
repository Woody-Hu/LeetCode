using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class all_elements_in_two_binary_search_trees
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var queue1 = new Queue<int>();
            var queue2 = new Queue<int>();
            InOrder(root1, queue1);
            InOrder(root2, queue2);
            var res = new List<int>();
            while (true)
            {
                if (queue1.Any() && queue2.Any())
                {
                    var v1 = queue1.Peek();
                    var v2 = queue2.Peek();
                    if (v1 < v2)
                    {
                        res.Add(v1);
                        queue1.Dequeue();
                    }
                    else
                    {
                        res.Add(v2);
                        queue2.Dequeue();
                    }
                }
                else if (queue1.Any())
                {
                    res.Add(queue1.Dequeue());
                }
                else if (queue2.Any())
                {
                    res.Add(queue2.Dequeue());
                }
                else
                {
                    break;
                }
            }

            return res;
        }

        private void InOrder(TreeNode root, Queue<int> queue)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left, queue);
            queue.Enqueue(root.val);
            InOrder(root.right, queue);
        }
    }
}
