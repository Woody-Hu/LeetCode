using System;

namespace LeetCode;

public class earliest_finish_time_for_land_and_water_rides_i
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        var earliest1 = EarliestFinishTimeInternal(landStartTime, landDuration, waterStartTime, waterDuration);
        var earliest2 = EarliestFinishTimeInternal(waterStartTime, waterDuration, landStartTime, landDuration);
        return Math.Min(earliest1, earliest2);
    }

    private int EarliestFinishTimeInternal(int[] firstStart, int[] firstDuration, int[] secondStart,
        int[] secondDuration)
    {
        var earliestFinish = int.MaxValue;
        var firstLength = firstStart.Length;
        var secondLength = secondStart.Length;
        for (var i = 0; i < firstLength; i++)
        {
            var firstEnd = firstStart[i] + firstDuration[i];
            for (int j = 0; j < secondLength; j++)
            {
                var secondEnd = Math.Max(firstEnd, secondStart[j]) + secondDuration[j];
                earliestFinish = Math.Min(earliestFinish, secondEnd);
            }
        }

        return earliestFinish;
    }
}