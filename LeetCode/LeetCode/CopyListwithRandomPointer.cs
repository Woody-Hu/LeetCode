using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CopyListwithRandomPointer
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            if (null == head)
            {
                return null;
            }
            var dic = new Dictionary<RandomListNode, RandomListNode>();
            var createdNode = new RandomListNode(head.label);
            var useQueue = new Queue<RandomListNode>();
            useQueue.Enqueue(head);
            dic.Add(head,createdNode);

            while (useQueue.Count != 0)
            {
                var node = useQueue.Dequeue();
                var dicNode = dic[node];

                if (null != node.next)
                {
                    useQueue.Enqueue(node.next);
                    if (!dic.ContainsKey(node.next))
                    {
                        dic.Add(node.next,new RandomListNode(node.next.label));
                    }

                    dicNode.next = dic[node.next];
                }

                if (null != node.random)
                {
                    if (!dic.ContainsKey(node.random))
                    {
                        dic.Add(node.random, new RandomListNode(node.random.label));
                    }

                    dicNode.random = dic[node.random];
                }

            }

            return dic[head];
        }
    }
}
