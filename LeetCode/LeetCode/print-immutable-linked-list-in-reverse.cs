using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class print_immutable_linked_list_in_reverse
    {
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            if (head == null)
            {
                return;
            }

            var list = new List<ImmutableListNode>();
            while (head != null)
            {
                list.Add(head);
                head = head.GetNext();
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                list[i].PrintValue();
            }
        }

        public abstract class ImmutableListNode
        {
           public abstract  void PrintValue(); // print the value of this node.
           public abstract ImmutableListNode GetNext(); // return the next node.
        }
    }
}
