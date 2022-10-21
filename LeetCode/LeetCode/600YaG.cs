using System;
using System.Linq;

namespace LeetCode
{
    public class _00YaG
    {
        public int MinNumBooths(string[] demand)
        {
            var res = new int[26];
            foreach (var str in demand) 
            {
                var cur = new int[26];
                for (var i = 0; i < str.Length; i++)
                {
                    cur[str[i] - 'a']++;
                }

                for (var i = 0; i < str.Length; i++)
                {
                    if (res[str[i] - 'a'] != 0)
                    {
                        if (res[str[i] - 'a'] <= cur[str[i] - 'a'])
                        {
                            res[str[i] - 'a'] = cur[str[i] - 'a'];
                        }
                    }
                    else
                    {
                        res[str[i] - 'a'] = cur[str[i] - 'a'];
                    }

                }
            }

            return res.Sum();
        }
    }
}
