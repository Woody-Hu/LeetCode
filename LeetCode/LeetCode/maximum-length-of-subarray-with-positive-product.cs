using System;
namespace LeetCode
{
    public class maximum_length_of_subarray_with_positive_product
    {
        public int GetMaxLen(int[] nums)
        {
            var res = 0;
            var p = 0;
            var n = 0;
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    p = 0;
                    n = 0;
                }
                else if (item > 0)
                {
                    p = p + 1;
                    if (n > 0)
                    {
                        n = n + 1;
                    }
                }
                else if (item < 0)
                {
                    var temp = p;
                    p = n;
                    n = temp;
                    n = n + 1;
                    if (p > 0)
                    {
                        p = p + 1;
                    }

                }

                res = Math.Max(p, res);
            }

            return res;
        }
    }
}
