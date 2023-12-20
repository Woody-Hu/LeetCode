using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class sfvd7V
	{
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                var array = item.ToCharArray();
                Array.Sort(array);
                var temp = new string(array);
                if (!dic.ContainsKey(temp))
                {
                    dic.Add(temp, new List<string>());
                }

                dic[temp].Add(item);
            }

            var res = new List<IList<string>>();
            foreach (var item in dic)
            {
                res.Add(item.Value);
            }

            return res;
        }
    }
}

