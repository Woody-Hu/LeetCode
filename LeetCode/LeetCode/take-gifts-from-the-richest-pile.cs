using System;
using System.Collections.Generic;

namespace LeetCode;

public class take_gifts_from_the_richest_pile
{
    public long PickGifts(int[] gifts, int k)
    {
        var priorityQueue = new PriorityQueue<int, int>();
        foreach (var gift in gifts)
        {
            priorityQueue.Enqueue(gift, -gift);
        }

        while (k > 0)
        {
            k--;
            var t = priorityQueue.Dequeue();
            priorityQueue.Enqueue((int) Math.Sqrt(t), -(int) Math.Sqrt(t));
        }
        
        var res = 0L;
        while (priorityQueue.Count > 0)
        {
            res += priorityQueue.Dequeue();
        }

        return res;



    }
}