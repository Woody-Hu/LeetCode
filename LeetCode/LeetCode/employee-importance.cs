using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class employee_importance
    {
        public int GetImportance(IList<Employee> employees, int id)
        {
            var dic = new Dictionary<int, Employee>();
            foreach (var item in employees)
            {
                dic[item.id] = item;
            }

            return Visit(dic, id);
        }

        private int Visit(Dictionary<int, Employee> dic, int id)
        {
            if (!dic.ContainsKey(id))
            {
                return 0;
            }

            var current = dic[id];
            var res = current.importance;
            foreach (var item in current.subordinates)
            {
                res += Visit(dic, item);
            }

            return res;
        }


        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }
    }
}
