using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindtheClosestPalindrome
    {
        public string NearestPalindromic(string n)
        {
            long number = long.Parse(n);
            long big = findHigherPalindrome(number + 1);
            long small = findLowerPalindrome(number - 1);
            return Math.Abs(number - small) > Math.Abs(big - number) ? big.ToString() : small.ToString();
        }

        public long findHigherPalindrome(long limit)
        {
            String n = limit.ToString();
            char[] s = n.ToArray(); 
            int m = s.Length;
            char[] t = new char[m];  
            s.CopyTo(t, 0);
            for (int i = 0; i < m / 2; i++)
            {
                t[m - 1 - i] = t[i];
            }
            for (int i = 0; i < m; i++)
            {
                if (s[i] < t[i])
                {
                    return long.Parse(new string(t));
                }
                else if (s[i] > t[i])
                {
                    for (int j = (m - 1) / 2; j >= 0; j--)
                    {
                        if (++t[j] > '9')
                        {
                            t[j] = '0';
                        }
                        else
                        {
                            break;
                        }
                    }

                    for (int k = 0; k < m / 2; k++)
                    {
                        t[m - 1 - k] = t[k];
                    }
                    return long.Parse(new string(t));
                }
            }
            return long.Parse(new string(t));
        }

        public long findLowerPalindrome(long limit)
        {
            String n = limit.ToString();
            char[] s = n.ToArray(); // limit
            int m = s.Length;
            char[] t = new char[m];  // target
            s.CopyTo(t, 0);
            for (int i = 0; i < m / 2; i++)
            {
                t[m - 1 - i] = t[i];
            }
            for (int i = 0; i < m / 2; i++)
            {
                t[m - 1 - i] = t[i];
            }
            for (int i = 0; i < m; i++)
            {
                if (s[i] > t[i])
                {
                    return long.Parse(new string(t));
                }
                else if (s[i] < t[i])
                {
                    for (int j = (m - 1) / 2; j >= 0; j--)
                    {
                        if (--t[j] < '0')
                        {
                            t[j] = '9';
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (t[0] == '0')
                    {
                        char[] a = new char[m - 1];

                        for (int tempIndex = 0; tempIndex < a.Length; tempIndex++)
                        {
                            a[tempIndex] = '9';
                        }

                        return long.Parse(new string(a));
                    }

                    for (int k = 0; k < m / 2; k++)
                    {
                        t[m - 1 - k] = t[k];
                    }
                    return long.Parse(new string(t));
                }
            }
            return long.Parse(new string(t));
        }
    }
}
