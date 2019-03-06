 using System;
using System.Collections.Generic;
 using System.Linq;
 using System.Text;

namespace LeetCode
{
    class Minimum_Height_Trees
    {
        public IList<int> FindMinHeightTrees(int n, int[,] edges)
        {
            if (n == 1)
            {
                return new List<int>(){0};
            }

            var path = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < edges.GetLength(0); i++)
            {
                var index0 = edges[i, 0];
                var index1 = edges[i, 1];
                if (!path.ContainsKey(index0))
                {
                    path[index0] = new HashSet<int>();
                }

                path[index0].Add(index1);
                if (!path.ContainsKey(index1))
                {
                    path[index1] = new HashSet<int>();
                }
                path[index1].Add(index0);
            }

            var stack = new Stack<int>();

            foreach (var pathKvp in path)
            {
                if (pathKvp.Value.Count == 1)
                {
                    stack.Push(pathKvp.Key);
                }
            }

            while (n > 2)
            {
                n -= stack.Count;
                var nextStack = new Stack<int>();
                while (stack.Count != 0)
                {
                    var index = stack.Pop();
                    var anotherIndex = path[index].First();
                    path[anotherIndex].Remove(index);
                    if (path[anotherIndex].Count == 1)
                    {
                        nextStack.Push(anotherIndex);
                    }
                }

                stack = nextStack;
            }

            return stack.ToList();
        }
    }
}
