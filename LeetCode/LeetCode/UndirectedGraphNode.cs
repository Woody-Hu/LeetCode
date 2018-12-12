using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class UndirectedGraphNode
    {
          public int label;
          public IList<UndirectedGraphNode> neighbors;
          public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
    }
}
