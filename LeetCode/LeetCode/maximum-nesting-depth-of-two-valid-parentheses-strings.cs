using System;
namespace LeetCode
{
    public class maximum_nesting_depth_of_two_valid_parentheses_strings
    {
        public int[] MaxDepthAfterSplit(string seq)
        {
            var res = new int[seq.Length];
            var d = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] == '(')
                {
                    d++;
                    res[i] = d % 2;
                }
                else
                {
                    res[i] = d % 2;
                    d--;
                }
            }

            return res;
        }
    }
}
