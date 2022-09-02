using System;
namespace LeetCode
{
    public class nGK0Fy
    {
        public int Calculate(string s)
        {
            var x = 1;
            var y = 0;
            foreach (var item in s)
            {
                if (item == 'A')
                {
                    x = 2 * x + y;
                }
                else
                {
                    y = 2 * y + x;
                }
            }

            return x + y;
        }
    }
}
