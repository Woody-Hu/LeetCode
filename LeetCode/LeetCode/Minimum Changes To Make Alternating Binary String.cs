using System;
namespace LeetCode
{
    public class Minimum_Changes_To_Make_Alternating_Binary_String
    {
        public int MinOperations(string s)
        {
            var zeroones = 0;
            var onezeros = 0;
            int i = 0;
            foreach (var ch in s)
            {
                int n = ch - '0';
                zeroones += Math.Abs(i % 2 - n);
                onezeros += Math.Abs((i + 1) % 2 - n);
                i++;
            }


            return Math.Min(zeroones, onezeros);
        }
    }
}
