using System.Collections.Generic;

namespace LeetCode;

public class g5c51o
{
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            count.TryAdd(num, 0);
            count[num]++;
        }

        var priorityQueue = new PriorityQueue<int, int>();
        foreach (var (key, value) in count)
        {
            priorityQueue.Enqueue(key, value);
            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }
        
        var result = new int[k];
        for (var i = 0; i < k; i++)
        {
            result[i] = priorityQueue.Dequeue();
        }
        
        return result;
    }
}