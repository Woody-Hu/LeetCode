using System;

namespace LeetCode;

public class minimum_number_of_chairs_in_a_waiting_room
{
    public int MinimumChairs(string s)
    {
        var res = 0;
        var count = 0;
        foreach (var c in s)
        {
            if (c == 'E')
            {
                res = Math.Max(res, ++count);
            }
            else
            {
                count--;
            }
        }

        return res;

    }
}