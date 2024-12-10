using System;
using System.Collections.Generic;

namespace LeetCode;

public class time_to_cross_a_bridge
{
    public int FindCrossingTime(int n, int k, int[][] time) {
        PriorityQueue<int, long> waitLeft = new PriorityQueue<int, long>();
        PriorityQueue<int, long> waitRight = new PriorityQueue<int, long>();

        PriorityQueue<int[], long> workLeft = new PriorityQueue<int[], long>();
        PriorityQueue<int[], long> workRight = new PriorityQueue<int[], long>();

        int remain = n, curTime = 0;
        for (int i = 0; i < k; i++) {
            long priority = -(time[i][0] + time[i][2]) * (long) 1001 - i;
            waitLeft.Enqueue(i, priority);
        }
        while (remain > 0 || workRight.Count > 0 || waitRight.Count > 0) {
            while (workLeft.Count > 0 && workLeft.Peek()[0] <= curTime) {
                int val = workLeft.Dequeue()[1];
                long priority = -(time[val][0] + time[val][2]) * (long) 1001 - val;
                waitLeft.Enqueue(val, priority);
            }
            while (workRight.Count > 0 && workRight.Peek()[0] <= curTime) {
                int val = workRight.Dequeue()[1];
                long priority = -(time[val][0] + time[val][2]) * (long) 1001 - val;
                waitRight.Enqueue(val, priority);
            }

            if (waitRight.Count > 0) {
                int id = waitRight.Dequeue();
                curTime += time[id][2];
                long priority = (curTime + time[id][3]) * (long) 1001 + id;
                workLeft.Enqueue(new int[]{curTime + time[id][3], id}, priority);
            } else if (remain > 0 && waitLeft.Count > 0) {
                int id = waitLeft.Dequeue();
                curTime += time[id][0];
                long priority = (curTime + time[id][1]) * (long) 1001 + id;
                workRight.Enqueue(new int[]{curTime + time[id][1], id}, priority);
                remain--;
            } else {
                int nextTime = int.MaxValue;
                if (workLeft.Count > 0) {
                    nextTime = Math.Min(nextTime, workLeft.Peek()[0]);
                }
                if (workRight.Count > 0) {
                    nextTime = Math.Min(nextTime, workRight.Peek()[0]);
                }
                if (nextTime != int.MaxValue) {
                    curTime = Math.Max(nextTime, curTime);
                }
            }
        }
        
        return curTime;
    }
}