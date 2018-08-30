using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MyHashSet
    {
        int?[] useArray = new int?[1000000];

        /** Initialize your data structure here. */
        public MyHashSet()
        {

        }

        public void Add(int key)
        {
            useArray[key] = key;
        }

        public void Remove(int key)
        {
            useArray[key] = null;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
           return useArray[key].HasValue;
        }
    }
}
