using System.Collections.Generic;

namespace LeetCode;

public class find_indices_of_stable_mountains
{
    public IList<int> StableMountains(int[] height, int threshold)
    {
        var res = new List<int>();
        for (int i = 0; i < height.Length - 1; i++)
        {
            if (height[i] > threshold)
            {
                res.Add(i + 1);
            }
            
        }
        
        return res;

    }
    
}