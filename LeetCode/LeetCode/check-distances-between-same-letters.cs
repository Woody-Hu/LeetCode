using System;
namespace LeetCode
{
	public class check_distances_between_same_letters
	{
        public bool CheckDistances(string s, int[] distance)
        {
            var firstIndex = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                var index = s[i] - 'a';
                if (firstIndex[index] != 0 && i - firstIndex[index] != distance[index])
                {
                    return false;
                }

                firstIndex[index] = i + 1;
            }

            return true;
        }
    }
}

