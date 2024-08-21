using System;
using System.Collections.Generic;

namespace LeetCode;

public class minimum_number_of_operations_to_make_word_k_periodic
{
    public int MinimumOperationsToMakeKPeriodic(string word, int k) {
        var n = word.Length;
        var res = int.MaxValue;
        var dic = new Dictionary<string, int>();
        for (int i = 0; i < n; i+=k)
        {
            var temp = word.Substring(i, k);
            if (!dic.ContainsKey(temp))
            {
                dic[temp] = 0;
            }
            dic[temp]++;
            res = Math.Min(res, n/k - dic[temp]);
        }
        
        return res;



    }
}