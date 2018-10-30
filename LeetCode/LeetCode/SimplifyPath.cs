using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SimplifyPath
    {
        public string SimplifyPathMethod(string path)
        {
            string returnValue = "";

            if (string.IsNullOrWhiteSpace(path))
            {
                return path;
            }


            Stack<string> useStack = new Stack<string>();

            var useSplitValues = path.Split('/');

            foreach (var oneString in useSplitValues)
            {
                if (oneString.Equals("."))
                {
                    continue;
                }

                if (oneString.Equals(".."))
                {
                    if (useStack.Count != 0)
                    {
                        useStack.Pop();
                    }
                }
                else if (!oneString.Equals(""))
                {
                    useStack.Push(oneString);
                }
            }

            while (useStack.Count != 0)
            {
                returnValue = "/" + useStack.Pop() + returnValue;
            }

            return returnValue.Equals("") ? "/" : returnValue;
        }
    }
}
