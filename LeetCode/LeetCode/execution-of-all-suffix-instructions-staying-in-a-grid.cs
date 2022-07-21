using System;
namespace LeetCode
{
    public class execution_of_all_suffix_instructions_staying_in_a_grid
    {
        public int[] ExecuteInstructions(int n, int[] startPos, string s)
        {
            var res = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                var x = startPos[0];
                var y = startPos[1];
                var count = 0;
                for (int j = i; j < s.Length; j++)
                {
                    var value = s[j];
                    if (value == 'L')
                    {
                        --y;
                    }
                    else if (value == 'R')
                    {
                        ++y;
                    }
                    else if (value == 'U')
                    {
                        --x;
                    }
                    else
                    {
                        ++x;
                    }

                    if (x < 0 || x >= n || y < 0 || y >= n)
                    {
                        break;
                    }

                    count++;
                }

                res[i] = count;
            }

            return res;
        }
    }
}
