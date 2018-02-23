using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

 public class ListNode {
    public int val;
    public ListNode next;
     public ListNode(int x) {
         val = x;
        next = null;
     }
 }

    public partial class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (null == head)
            {
                return false;
            }

            ListNode sNode;
            ListNode fNode;
            sNode = head;
            fNode = sNode;
            while (null != fNode.next && null != fNode.next.next)
            {
                sNode = sNode.next;
                fNode = fNode.next.next;
                if (sNode == fNode)
                {
                    return true;
                }
            }
            return false;

            /*
            ListNode kNode;
            ListNode iNode;
            kNode=head;
            iNode=kNode;
            while(kNode.next != null)
            {
                kNode=kNode.next;
                if (iNode == kNode)
                {
                    return true;
                }
            }
            return false;
            */
        }
    }
}
