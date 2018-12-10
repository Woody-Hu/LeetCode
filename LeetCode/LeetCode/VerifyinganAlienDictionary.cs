using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class VerifyinganAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var dic = new Dictionary<char,int>();

            for (var i = 0; i < order.Length; i++)
            {
                dic.Add(order[i],i);
            }

            for (var i = 0; i < words.Length - 1; i++)
            {
                if (!Compare(words[i],words[i+1],dic))
                {
                    return false;
                }
            }

            return true;

        }

        private bool Compare(string stringOne, string stringTwo, Dictionary<char, int> dic)
        {
            var length = Math.Min(stringOne.Length, stringTwo.Length);

            for (var i = 0; i < length; i++)
            {
                if (dic[stringOne[i]] < dic[stringTwo[i]])
                {
                    return true;
                }
                else if (dic[stringOne[i]] > dic[stringTwo[i]])
                {
                    return false;
                }
            }

            if (stringOne.Length > stringTwo.Length)
            {
                return false;
            }

            return true;
        }
    }
}
