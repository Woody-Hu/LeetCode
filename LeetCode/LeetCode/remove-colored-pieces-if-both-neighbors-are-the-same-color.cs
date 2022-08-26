using System;
namespace LeetCode
{
    public class remove_colored_pieces_if_both_neighbors_are_the_same_color
    {
        public bool WinnerOfGame(string colors)
        {
            var counts = new int[] { 0, 0 };
            var current = 'C';
            var count = 0;
            for (int i = 0; i < colors.Length; i++)
            {
                var charValue = colors[i];
                if (charValue != current)
                {
                    current = charValue;
                    count = 1;
                }
                else
                {
                    count++;
                    if (count >= 3)
                    {
                        counts[charValue - 'A'] += 1;
                    }
                }
            }

            return counts[0] > counts[1];
        }
    }
}
