using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class words_within_two_edits_of_dictionary
    {
        public IList<string> TwoEditWords(string[] queries, string[] dictionary)
        {
            var res = new List<string>();
            foreach (var query in queries)
            {
                foreach (var item in dictionary)
                {
                    if (query.Length != item.Length)
                    {
                        continue;
                    }

                    var diff = 0;
                    for (int i = 0; i < query.Length; i++)
                    {
                        if (query[i] != item[i])
                        {
                            diff++;
                            if (diff > 2)
                            {
                                break;
                            }
                        }
                    }

                    if (diff <= 2)
                    {
                        res.Add(query);
                        break;
                    }
                }
            }

            return res;
        }
    }
}

