using System;

namespace LeetCode;

public class shortest_impossible_sequence_of_rolls
{
    public int ShortestSequence(int[] rolls, int k) {
        int count = 1;
        int diffCount = 0;
        bool[] exists = new bool[k + 1];

        for (int i = 0; i < rolls.Length; i++)
        {
            if (exists[rolls[i]]) continue;

            exists[rolls[i]] = true;

            if (++diffCount == k)
            {
                diffCount = 0;
                count++;
                Array.Fill(exists, false);
            }

        }

        return count;
    }
}