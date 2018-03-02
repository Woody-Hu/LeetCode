using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LFUCache
    {
        Dictionary<int, int> useValueDic = new Dictionary<int, int>();

        Dictionary<int, int> useKeyCountDic = new Dictionary<int, int>();

        Dictionary<int, LinkedList<int>> useCountKeyListDic = new Dictionary<int, LinkedList<int>>();

        int useCapacity = 0;

        int nowMinCount = 1;

        public LFUCache(int capacity)
        {
            useCapacity = capacity;
            useCountKeyListDic.Add(nowMinCount, new LinkedList<int>());
        }

        public int Get(int key)
        {
            if (!useValueDic.ContainsKey(key))
            {
                return -1;
            }

            int nowUseCount = useKeyCountDic[key];
            useCountKeyListDic[nowUseCount].Remove(key);

            if (nowUseCount == nowMinCount && useCountKeyListDic[nowUseCount].Count == 0)
            {
                nowMinCount++;
            }

            useKeyCountDic[key] = useKeyCountDic[key] + 1;
 
            nowUseCount = nowUseCount + 1;

            if (!useCountKeyListDic.ContainsKey(nowUseCount))
            {
                useCountKeyListDic.Add(nowUseCount, new LinkedList<int>());
            }

            useCountKeyListDic[nowUseCount].AddLast(key);

            return useValueDic[key];

        }

        public void Put(int key, int value)
        {
            if (useCapacity <= 0)
            {
                return;
            }

            if (useValueDic.ContainsKey(key))
            {
                Get(key);
                useValueDic[key] = value;
                return;
            }

            if ((useValueDic.Count + 1) > useCapacity)
            {
                int useKey = useCountKeyListDic[nowMinCount].First();
                useCountKeyListDic[nowMinCount].RemoveFirst();
                useValueDic.Remove(useKey);
                useKeyCountDic.Remove(useKey);
            }

            useValueDic.Add(key, value);
            useKeyCountDic.Add(key, 1);
            nowMinCount = 1;
            useCountKeyListDic[nowMinCount].AddLast(key);
        }
    }
}
