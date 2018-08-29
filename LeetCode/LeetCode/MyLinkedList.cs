using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MyLinkedList
    {
        private InnerNode startNode;

        private int count;


        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            count = 0;
            startNode = new InnerNode() { value = -1 };
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index >= count)
            {
                return -1;
            }

            InnerNode prev = startNode;
            for (int i = 0; i < index; i++)
            {
                prev = prev.nextNode;
            }

            return prev.nextNode.value;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(count, val);

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > count)
            {
                return;
            }

            InnerNode prev = startNode;
            for (int i = 0; i < index; i++)
            {
                prev = prev.nextNode;
            }


            prev.nextNode = new InnerNode() { value = val,nextNode = prev.nextNode};

            count++;

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                return;
            }

            InnerNode prev = startNode;
            for (int i = 0; i < index; i++)
            {
                prev = prev.nextNode;
            }

            InnerNode delNode = prev.nextNode;
            prev.nextNode = delNode.nextNode;
            delNode.nextNode = null;

            count--;
        }

      


        private class InnerNode
        {
            internal int value;

            internal InnerNode nextNode;
        }
    }
}
