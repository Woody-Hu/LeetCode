using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NetworkDelayTime
    {
        public int NetworkDelayTimeMethod(int[,] times, int N, int K)
        {
            Dictionary<int, List<int>> routeDictionary = new Dictionary<int, List<int>>();

            for (int i = 0; i < times.GetLength(0); i++)
            {
                if (!routeDictionary.ContainsKey(times[i,0]))
                {
                    routeDictionary.Add(times[i,0],new List<int>());
                }

                routeDictionary[times[i,0]].Add(i);
            }

            if (!routeDictionary.ContainsKey(K))
            {
                return -1;
            }

            int[] distanceArray = new int[N+1];

            Array.Fill(distanceArray, int.MaxValue);

            distanceArray[K] = 0;

            Queue<int> useQueue = new Queue<int>();

            useQueue.Enqueue(K);

            while (useQueue.Count != 0)
            {
                var tempU = useQueue.Dequeue();
                var uLst = routeDictionary.GetValueOrDefault(tempU);

                if (null == uLst)
                {
                    continue;
                }

                var nowDis = distanceArray[tempU];

                foreach (var oneValue in uLst)
                {
                    var tempV = times[oneValue, 1];
                    var tempTime = times[oneValue, 2];

                    if ( distanceArray[tempV] > nowDis + tempTime )
                    {
                        distanceArray[tempV] = nowDis + tempTime;
                        useQueue.Enqueue(tempV);
                    }
                }
            }

            var returnValue = 0;

            for (int i = 1; i < distanceArray.Length; i++)
            {
                if (distanceArray[i] == int.MaxValue)
                {
                    return -1;
                }

                returnValue = Math.Max(returnValue, distanceArray[i]);
            }

            return returnValue;
        }
    }
}
