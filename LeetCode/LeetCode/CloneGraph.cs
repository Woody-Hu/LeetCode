using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class CloneGraph
    {
        public UndirectedGraphNode CloneGraphMethod(UndirectedGraphNode node)
        {
            if (null == node)
            {
                return null;
            }
            var queue = new Queue<UndirectedGraphNode>();
            var dic = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            queue.Enqueue(node);
            dic.Add(node,new UndirectedGraphNode(node.label));

            while (queue.Count != 0)
            {
                var useNode = queue.Dequeue();

                foreach (var oneNode in useNode.neighbors)
                {
                    if (!dic.ContainsKey(oneNode))
                    {
                        dic.Add(oneNode,new UndirectedGraphNode(oneNode.label));
                        queue.Enqueue(oneNode);
                    }
                    dic[useNode].neighbors.Add(dic[oneNode]);
                }
            }

            return dic[node];
        }
    }
}
