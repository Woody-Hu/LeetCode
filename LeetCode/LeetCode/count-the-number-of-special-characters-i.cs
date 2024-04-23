using System.Collections.Generic;

namespace LeetCode;

public class count_the_number_of_special_characters_i
{
    public int NumberOfSpecialChars(string word) {
        var count = 0;
        var mask = new int[2];
        foreach (var c in word)
        {
            mask[c >> 5 & 1] |= 1 << (c & 31);
        }
        
        return GetIntBitCount(mask[0] & mask[1]);
    }

    private int GetIntBitCount(int input)
    {
        var count = 0;
        while (input != 0)
        {
            count += input & 1;
            input >>= 1;
        }
        
        return count;
    }
}