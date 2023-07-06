using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class minimum_number_of_operations_to_sort_a_binary_tree_by_level
	{
        public int MinimumOperations(TreeNode root)
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
                var list = new List<int>();
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    list.Add(current.val);
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                var loop = 0;
                var temp = new List<int>(list);
                var flag = new bool[temp.Count];
                list.Sort();

                var dic = new Dictionary<int, int>();
                for (int i = 0; i < list.Count; i++)
                {
                    dic.Add(list[i], i);
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    if (!flag[i])
                    {
                        var j = i;
                        while (!flag[j])
                        {
                            var index = dic[temp[j]];
                            flag[j] = true;
                            j = index;
                        }
                        loop++;
                    }
                }

                res += temp.Count - loop;
            }


            return res;
        }
    }
}

