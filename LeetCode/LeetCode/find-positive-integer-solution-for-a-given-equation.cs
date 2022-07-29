using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_positive_integer_solution_for_a_given_equation
    {
        public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            var res = new List<IList<int>>();
            var x = 1;
            var y = 1000;
            while (x <= 1000 && y >= 1)
            {
                var temp = customfunction.f(x, y);
                if (temp < z)
                {
                    x++;
                }
                else if (temp > z)
                {
                    y--;
                }
                else
                {
                    res.Add(new List<int>() { x, y });
                    x++;
                }
            }

            return res;
        }

        public class CustomFunction
        {
            // Returns f(x, y) for any given positive integers x and y.
            // Note that f(x, y) is increasing with respect to both x and y.
            // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
            public int f(int x, int y)
            {
                return 0;
            }
        };
    }
}
