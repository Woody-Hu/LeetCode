using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class search_suggestions_system
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var preDic = new Dictionary<string, List<string>>();
            foreach (var item in products)
            {
                var name = string.Empty;
                foreach (var itemChar in item)
                {
                    name += itemChar;
                    if (!preDic.ContainsKey(name))
                    {
                        preDic.Add(name, new List<string>());
                    }

                    preDic[name].Add(item);
                }
            }

            var res = new List<IList<string>>();
            var match = string.Empty;
            foreach (var item in searchWord)
            {
                match += item;
                if (!preDic.ContainsKey(match))
                {
                    res.Add(new List<string>());
                }
                else
                {
                    var values = preDic[match];
                    var ordered = values.OrderBy(k => k);
                    if (ordered.Count() < 3)
                    {
                        res.Add(ordered.ToList());
                    }
                    else
                    {
                        res.Add(new List<string>() { ordered.ElementAt(0), ordered.ElementAt(1), ordered.ElementAt(2) });
                    }
                }
            }

            return res;
        }
    }
}
