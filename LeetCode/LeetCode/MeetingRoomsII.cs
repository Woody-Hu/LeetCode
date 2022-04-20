using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MeetingRoomsII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            var ordered =  intervals.OrderBy(k => k[0]);
            var list = new List<int[]>();
            foreach (var item in ordered)
            {
                var found = false;
                var currentStart = item[0];
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i] != null && list[i][1] <= currentStart)
                    {
                        list[i] = null;
                    }

                    if (list[i] == null)
                    {
                        list[i] = item;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    list.Add(item);
                }
            }

            return list.Count();
        }
    }
}
