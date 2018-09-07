using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MyHashMap
    {
        int?[] useArray = new int?[1000000];

        /** Initialize your data structure here. */
        public MyHashMap()
        {

        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            useArray[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return useArray[key] == null?-1:useArray[key].Value;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            useArray[key] = null;
        }
    }
}
