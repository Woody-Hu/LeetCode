using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class all_possible_full_binary_trees
	{
		public IList<TreeNode> AllPossibleFBT(int n)
		{
			return AllPossibleFBT(n, new Dictionary<int, IList<TreeNode>>());
		}

		private IList<TreeNode> AllPossibleFBT(int n, Dictionary<int, IList<TreeNode>> cache)
		{
			if (cache.TryGetValue(n, out var exist))
			{
				return exist;
			}
			else
			{
				var res = new List<TreeNode>();
                if (n == 1)
                {
					res.Add(new TreeNode(0));
                }
                else if (n % 2 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
						var j = n - 1 - i;
                        foreach (var left in AllPossibleFBT(i, cache))
                        {
                            foreach (var right in AllPossibleFBT(j, cache))
                            {
								var node = new TreeNode(0);
								node.left = left;
								node.right = right;
								res.Add(node);
                            }
                        }
                    }
                }

				cache[n] = res;
				return res;
			}
		}
	}
}

