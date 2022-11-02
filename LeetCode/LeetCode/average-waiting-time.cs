using System;
namespace LeetCode
{
    public class average_waiting_time
    {
        public double AverageWaitingTime(int[][] customers)
        {
            var sumWait = 0.0d;
            var start = 0;
            var n = customers.Length;
            foreach (var item in customers)
            {
                var arrival = item[0];
                start = Math.Max(start, arrival) + item[1];
                sumWait += start - arrival;
            }

            return sumWait / n;
        }
    }
}

