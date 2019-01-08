using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LRUCache
    {
        private int _capacity;

        private Dictionary<int, CacheItem> _cacheDic = new Dictionary<int, CacheItem>();

        private CacheItem _header = new CacheItem();

        private CacheItem _trail = new CacheItem();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _header.Next = _trail;
            _trail.Front = _header;
        }

        public int Get(int key)
        {
            if (!_cacheDic.ContainsKey(key))
            {
                return -1;
            }

            var item = _cacheDic[key];

            item.Front.Next = item.Next;
            item.Next.Front = item.Front;

            item.Next = _header.Next;
            item.Front = _header;
            _header.Next = item;

            item.Next.Front = item;

            return item.Value;
        }

        public void Put(int key, int value)
        {
            if (!_cacheDic.TryGetValue(key, out CacheItem item))
            {
                item = new CacheItem();
                item.Key = key;
                item.Value = value;

                item.Next = _header.Next;
                item.Front = _header;
                _header.Next = item;

                item.Next.Front = item;
                _cacheDic.Add(key, item);
            }
            else
            {
                item.Value = value;
                item.Front.Next = item.Next;
                item.Next.Front = item.Front;

                item.Next = _header.Next;
                item.Front = _header;
                _header.Next = item;

                item.Next.Front = item;
            }

            if (_cacheDic.Count > _capacity)
            {
                var itemNeedRemoved = _trail.Front;

                itemNeedRemoved.Front.Next = itemNeedRemoved.Next;
                itemNeedRemoved.Next.Front = itemNeedRemoved.Front;

                _cacheDic.Remove(itemNeedRemoved.Key);
            }
        }

        private class CacheItem
        {
            internal int Key { get; set; }

            internal int Value { get; set; }

            internal CacheItem Front { get; set; }

            internal CacheItem Next { get; set; }
        }

    }
}
