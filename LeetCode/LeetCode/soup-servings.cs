using System;
namespace LeetCode
{
    public class soup_servings
    {
        public double SoupServings(int n)
        {
            n = Math.Min(200, (int)Math.Ceiling(n / 25.0d));
            var f = new double[n + 10, n + 10];
            f[0, 0] = 0.5;
            for (int j = 1; j <= n; j++)
            {
                f[0, j] = 1;
            }


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    var a = f[Math.Max(i - 4, 0), j];
                    var b = f[Math.Max(i - 3, 0), Math.Max(j - 1, 0)];
                    var c = f[Math.Max(i - 2, 0), Math.Max(j - 2, 0)];
                    var d = f[Math.Max(i - 1, 0), Math.Max(j - 3, 0)];
                    f[i, j] = 0.25 * (a + b + c + d);
                }
            }

            return f[n, n];
        }
    }
}
