using System;
namespace LeetCode
{
	public class neighboring_bitwise_xor
	{
        public bool DoesValidArrayExist(int[] derived)
        {
            var res = 0;
            for (int i = 0; i < derived.Length; i++)
            {
                res = res ^ derived[i];
            }

            return res == 0;
        }
    }
}

