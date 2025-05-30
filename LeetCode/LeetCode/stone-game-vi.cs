using System;

namespace LeetCode;

public class stone_game_vi
{
    public int StoneGameVI(int[] aliceValues, int[] bobValues) {
        int n = aliceValues.Length;
        int[][] values = new int[n][];
        for (int i = 0; i < n; i++) {
            values[i] = new int[3];
            values[i][0] = aliceValues[i] + bobValues[i];
            values[i][1] = aliceValues[i];
            values[i][2] = bobValues[i];
        }
        Array.Sort(values, (a, b) => b[0] - a[0]);
        int aliceSum = 0, bobSum = 0;
        for (int i = 0; i < n; i++) {
            if (i % 2 == 0) {
                aliceSum += values[i][1];
            } else {
                bobSum += values[i][2];
            }
        }
        if (aliceSum > bobSum) {
            return 1;
        } else if (aliceSum == bobSum) {
            return 0;
        } else {
            return -1;
        }
    }
}