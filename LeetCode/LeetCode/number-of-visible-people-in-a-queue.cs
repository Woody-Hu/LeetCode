using System.Collections.Generic;

namespace LeetCode;

public class number_of_visible_people_in_a_queue
{
    public int[] CanSeePersonsCount(int[] heights) {
        var n = heights.Length;
        var stack = new Stack<int>();
        var result = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            var h = heights[i];
            while (stack.Count > 0 &&  h > stack.Peek())
            {
                result[i]++;
                stack.Pop();
            }
            if (stack.Count > 0)
            {
                result[i]++;
            }
            
            stack.Push(h);
        }

        return result;
    }
}