using System;
namespace LeetCode
{
	public class construct_the_longest_new_string
	{
        public int LongestString(int x, int y, int z)
        {
            return (Math.Min(x, y) * 2+ (x != y ? 1 : 0) + z) * 2;
        }
    }
}

