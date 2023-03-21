using System;
namespace LeetCode
{
	public class mirror_reflection
	{
        public int MirrorReflection(int p, int q)
        {
            var g = GCD(p, q);
            p /= g; p %= 2;
            q /= g; q %= 2;
            if (p == 1 && q == 1)
            {
                return 1;
            }

            return p == 1 ? 0 : 2;
        }

        private int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            return GCD(b % a, a);
        }
    }
}

