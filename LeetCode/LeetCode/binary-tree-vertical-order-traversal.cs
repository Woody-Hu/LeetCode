using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class binary_tree_vertical_order_traversal
	{
		public IList<IList<int>> VerticalOrder(TreeNode root)
		{
			var res = new List<IList<int>>();
            if (root == null)
            {
				return res;
            }

			var queue1 = new Queue<TreeNode>();
			var queue2 = new Queue<int>();
			queue1.Enqueue(root);
			queue2.Enqueue(0);
			var minLocation = int.MaxValue;
			var dic = new Dictionary<int, List<int>>();
            while (queue1.Any())
            {
				var node = queue1.Dequeue();
				var location = queue2.Dequeue();
                if (!dic.ContainsKey(location))
                {
					minLocation = Math.Min(minLocation, location);
					dic.Add(location, new List<int>());
                }

				dic[location].Add(node.val);

                if (node.left != null)
                {
					queue1.Enqueue(node.left);
					queue2.Enqueue(location - 1);
                }

				if (node.right != null)
                {
					queue1.Enqueue(node.right);
					queue2.Enqueue(location + 1);
				}
            }

            while (dic.ContainsKey(minLocation))
            {
				res.Add(dic[minLocation++]);
            }

			return res;
		}
	}
}

