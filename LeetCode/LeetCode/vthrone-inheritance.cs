using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class vthrone_inheritance
    {
        public class ThroneInheritance
        {
            private Dictionary<string, List<string>> _dic = new Dictionary<string, List<string>>();
            private HashSet<string> _set = new HashSet<string>();
            private string _kingName;

            public ThroneInheritance(string kingName)
            {
                _kingName = kingName;
            }

            public void Birth(string parentName, string childName)
            {
                if (!_dic.ContainsKey(parentName))
                {
                    _dic.Add(parentName, new List<string>());
                }

                _dic[parentName].Add(childName);
            }

            public void Death(string name)
            {
                _set.Add(name);
            }

            public IList<string> GetInheritanceOrder()
            {
                var res = new List<string>();
                PreOrder(res, _kingName);
                return res;
            }

            private void PreOrder(IList<string> list, string name)
            {
                if (!_set.Contains(name))
                {
                    list.Add(name);
                }

                if (_dic.TryGetValue(name, out var nextList))
                {
                    foreach (var item in nextList)
                    {
                        PreOrder(list, item);
                    }
                }
            }
        }
    }
}
