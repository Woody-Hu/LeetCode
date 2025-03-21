using System;

namespace LeetCode;

public class minimum_initial_energy_to_finish_tasks
{
    public int MinimumEffort(int[][] tasks) {
        int minEnergy = 0;
        Array.Sort(tasks, (a, b) => (b[1] - b[0]) - (a[1] - a[0]));
        for (int i = tasks.Length - 1; i >= 0; i--) {
            int[] task = tasks[i];
            minEnergy = Math.Max(minEnergy + task[0], task[1]);
        }
        return minEnergy;
    }
}