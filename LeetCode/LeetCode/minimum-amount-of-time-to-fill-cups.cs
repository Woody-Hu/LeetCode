using System;

namespace LeetCode;

public class minimum_amount_of_time_to_fill_cups
{
    public int FillCups(int[] amount)
    {
        Array.Sort(amount);
        if (amount[2] > amount[0] + amount[1])
        {
            return amount[2];
        }
        else
        {
            return (amount[0] + amount[1] + amount[2] + 1) / 2; // Use integer division to round up
        }

    }
}