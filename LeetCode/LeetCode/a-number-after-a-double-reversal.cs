using System;
namespace LeetCode
{
	public class a_number_after_a_double_reversal
	{
        public bool IsSameAfterReversals(int num)
        {
            return num == 0 || num % 10 != 0;
        }
    }
}

