using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class destination_city
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var set = new HashSet<string>();
            foreach (var item in paths)
            {
                set.Add(item[0]);
            }

            foreach (var item in paths)
            {
                if (!set.Contains(item[1]))
                {
                    return item[1];
                }
            }

            return string.Empty;
        }
    }
}
