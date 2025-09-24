using System;

namespace LeetCode;

public class earliest_time_to_finish_one_task
{
    public int EarliestTime(int[][] tasks) {
        int earliest = int.MaxValue;
        foreach (int[] task in tasks) {
            earliest = Math.Min(earliest, task[0] + task[1]);
        }
        return earliest;
    }
    
}