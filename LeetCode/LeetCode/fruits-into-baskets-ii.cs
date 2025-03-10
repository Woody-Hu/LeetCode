using System.Collections.Generic;

namespace LeetCode;

public class fruits_into_baskets_ii
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var set = new HashSet<int>();
        var n = fruits.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (set.Contains(j))
                {
                    continue;
                }
                
                if (fruits[i] <= baskets[j])
                {
                    set.Add(j);
                    break;
                }
            }
        }
        
        return n - set.Count;

    }
}