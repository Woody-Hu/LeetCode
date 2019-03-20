using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Reconstruct_Itinerary
    {
        public IList<string> FindItinerary(string[,] tickets)
        {
            var dic = new Dictionary<string, List<string>>();

            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                var key = tickets[i, 0];
                var value = tickets[i, 1];
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, new List<string>());
                }

                dic[key].Add(value);
            }

            for (int i = 0; i < dic.Count; i++)
            {
                var key = dic.ElementAt(i).Key;
                dic[key].Sort();
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("JFK");   
            var list = new List<string>();
            while (stack.Any())
            {
                while (dic.ContainsKey(stack.Peek()) && dic[stack.Peek()].Any())
                {
                    var next = dic[stack.Peek()].First();  
                    dic[stack.Peek()].RemoveAt(0); 
                    stack.Push(next); 
                }
                list.Insert(0, stack.Pop());
            }

            return list;
        }
    }
}
