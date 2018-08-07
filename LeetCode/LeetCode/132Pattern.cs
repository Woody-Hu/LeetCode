using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _132Pattern
    {
        public bool Find132pattern(int[] nums)
        {
            Stack<KeyValuePair<int, int>> useStack = new Stack<KeyValuePair<int, int>>();

            foreach (var oneValue in nums)
            {
                if (useStack.Count == 0 || oneValue < useStack.Peek().Key)
                {
                    useStack.Push(new KeyValuePair<int, int>(oneValue, oneValue));
                }
                else if(oneValue > useStack.Peek().Key)
                {
                    var tempKVP = useStack.Pop();
                    if (oneValue < tempKVP.Value)
                    {
                        return true;
                    }
                    else 
                    {
                        tempKVP = new KeyValuePair<int, int>(tempKVP.Key, oneValue);

                        while (useStack.Count !=0 && oneValue >= useStack.Peek().Value)
                        {
                            useStack.Pop();
                        }

                        if (useStack.Count !=0 && oneValue > useStack.Peek().Key)
                        {
                            return true;
                        }


                        useStack.Push(tempKVP);
                    }
                }

            }

            return false;
     
        }
    }
}
