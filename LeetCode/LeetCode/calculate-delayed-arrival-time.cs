using System;
namespace LeetCode
{
	public class calculate_delayed_arrival_time
	{
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            return (arrivalTime + delayedTime) % 24;
        }
    }
}

