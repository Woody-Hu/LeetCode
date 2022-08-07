using System;
namespace LeetCode
{
    public class longer_contiguous_segments_of_ones_than_zeros
    {
        public bool CheckZeroOnes(string s)
        {
            var maxZ = 0;
            var maxO = 0;
            var current = 0;
            var continueZ = true;
            foreach (var item in s)
            {
                if (item == '0')
                {
                    if (continueZ)
                    {
                        current++;
                    }
                    else
                    {
                        continueZ = true;
                        current = 1;
                    }

                    maxZ = Math.Max(maxZ, current);
                }
                else
                {
                    if (!continueZ)
                    {
                        current++;
                    }
                    else
                    {
                        continueZ = false;
                        current = 1;
                    }

                    maxO = Math.Max(maxO, current);
                }
            }

            return maxO > maxZ;
        }
    }
}

