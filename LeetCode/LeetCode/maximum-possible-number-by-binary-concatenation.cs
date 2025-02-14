using System;

namespace LeetCode;

public class maximum_possible_number_by_binary_concatenation
{
    static int[][] permutations = {new int[]{0, 1, 2}, new int[]{0, 2, 1}, new int[]{1, 0, 2}, new int[]{1, 2, 0}, new int[]{2, 0, 1}, new int[]{2, 1, 0}};

    public int MaxGoodNumber(int[] nums) {
        int[] binaryBits = new int[3];
        for (int i = 0; i < 3; i++) {
            binaryBits[i] = GetBinaryBits(nums[i]);
        }
        int maxPossible = 0;
        foreach (int[] permutation in permutations) {
            int concatenated = 0;
            for (int i = 0; i < 3; i++) {
                int index = permutation[i];
                concatenated = (concatenated << binaryBits[index]) + nums[index];
            }
            maxPossible = Math.Max(maxPossible, concatenated);
        }
        return maxPossible;
    }

    public int GetBinaryBits(int n) {
        int binaryBits = 0;
        while (n > 0) {
            n /= 2;
            binaryBits++;
        }
        return binaryBits;
    }
}