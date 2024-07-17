using System;

namespace LeetCode;

public class max_pair_sum_in_an_array
{
    public int MaxSum(int[] nums)
    {
        var res = -1;
        var maxVal = new int[10];
        Array.Fill(maxVal, int.MinValue);
        foreach (var item in nums)
        {
            var temp = 0;
            for (int i = item; i > 0; i /= 10)
            {
                temp = Math.Max(temp, i % 10);
            }

            res = Math.Max(res, item + maxVal[temp]);
            maxVal[temp] = Math.Max(maxVal[temp], item);

        }

        return res;


    }
}