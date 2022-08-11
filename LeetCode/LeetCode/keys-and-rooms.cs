using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class keys_and_rooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var set = new HashSet<int>();
            var res = 0;
            Visit(rooms, 0, set, ref res);
            return res == rooms.Count;
        }

        private void Visit(IList<IList<int>> rooms, int current, HashSet<int> set, ref int count)
        {
            set.Add(current);
            count++;
            foreach (var item in rooms[current])
            {
                if (!set.Contains(item))
                {
                    Visit(rooms, item, set, ref count);
                }
            }
        }
    }
}
