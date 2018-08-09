using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

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
