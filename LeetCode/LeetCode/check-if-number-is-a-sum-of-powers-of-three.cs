using System;
namespace LeetCode
{
    public class check_if_number_is_a_sum_of_powers_of_three
    {
        public bool CheckPowersOfThree(int n)
        {
            while (n > 0)
            {
                if (n%3 >1)
                {
                    return false;
                }

                n = n / 3;
            }

            return true;
        }
    }
}
