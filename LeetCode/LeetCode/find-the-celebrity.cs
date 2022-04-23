using System;
namespace LeetCode
{
    public class find_the_celebrity
    {
        public int FindCelebrity(int n)
        {
            var resut = 0;
            for (int i = 0; i < n; i++)
            {
                if (!Knows(i, resut))
                {
                    resut = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i == resut)
                {
                    continue;
                }

                if (!Knows(i, resut))
                {
                    return -1;
                }

                if (Knows(resut, i))
                {
                    return -1;
                }
            }

            return resut;

        }

        private bool Knows(int a, int b)
        {
            return false;
        }
    }
}

