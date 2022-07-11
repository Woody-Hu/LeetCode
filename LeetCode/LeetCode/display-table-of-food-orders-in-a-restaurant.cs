using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class display_table_of_food_orders_in_a_restaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            ISet<string> nameSet = new HashSet<string>();
            Dictionary<int, Dictionary<string, int>> foodsCnt = new Dictionary<int, Dictionary<string, int>>();
            foreach (IList<string> order in orders)
            {
                nameSet.Add(order[2]);
                int id = int.Parse(order[1]);
                Dictionary<string, int> dictionary = foodsCnt.ContainsKey(id) ? foodsCnt[id] : new Dictionary<string, int>();
                if (dictionary.ContainsKey(order[2]))
                {
                    ++dictionary[order[2]];
                }
                else
                {
                    dictionary.Add(order[2], 1);
                }
                if (!foodsCnt.ContainsKey(id))
                {
                    foodsCnt.Add(id, dictionary);
                }
            }

            int n = nameSet.Count;
            List<string> names = new List<string>();
            foreach (string name in nameSet)
            {
                names.Add(name);
            }
            names.Sort((a, b) => string.CompareOrdinal(a, b));

            int m = foodsCnt.Count;
            List<int> ids = new List<int>();
            foreach (int id in foodsCnt.Keys)
            {
                ids.Add(id);
            }
            ids.Sort();

            IList<IList<string>> table = new List<IList<string>>();
            IList<string> header = new List<string>();
            header.Add("Table");
            foreach (string name in names)
            {
                header.Add(name);
            }
            table.Add(header);
            for (int i = 0; i < m; ++i)
            {
                int id = ids[i];
                Dictionary<string, int> cnt = foodsCnt[id];
                IList<string> row = new List<string>();
                row.Add(id.ToString());
                for (int j = 0; j < n; ++j)
                {
                    int val = cnt.ContainsKey(names[j]) ? cnt[names[j]] : 0;
                    row.Add(val.ToString());
                }
                table.Add(row);
            }
            return table;
        }
    }
}
