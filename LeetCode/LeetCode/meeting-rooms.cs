using System;
using System.Linq;

namespace LeetCode
{
    public class meeting_rooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (k1, k2) => k1[0] - k2[0]);
            for (int i = 0; i < intervals.Count() - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
