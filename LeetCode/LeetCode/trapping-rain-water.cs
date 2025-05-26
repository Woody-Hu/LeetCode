using System;
using System.Collections.Generic;

namespace LeetCode;

public class trapping_rain_water
{
    public int Trap(int[] height) {
        Stack<int> stack = new Stack<int>();
        int sum = 0, n = height.Length, bottom, left;
        for (int right = 0; right < n; right++) {
            while (stack.Count > 0 && height[right] > height[stack.Peek()]) {
                bottom = stack.Pop();
                if (stack.Count > 0) {
                    left = stack.Peek();
                    sum += (Math.Min(height[right], height[left]) - height[bottom]) * (right - left - 1);
                }
            }

            if (stack.Count > 0 && height[right] == height[stack.Peek()]) 
                stack.Pop();
            stack.Push(right);
        }
        return sum;
    }
}