using System;
namespace LeetCode
{
    public class sign_of_the_product_of_an_array
    {
        public int ArraySign(int[] nums)
        {
            var count = 0;
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    return 0;
                }
                else if (item < 0)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
            {
                return 1;
            }

            return -1;
        }
    }
}
