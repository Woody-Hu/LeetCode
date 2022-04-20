using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class asteroid_collision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();
            foreach (var item in asteroids)
            {
                if (!stack.Any())
                {
                    stack.Push(item);
                }
                else if (item >= 0)
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Peek() < 0)
                    {
                        stack.Push(item);
                    }
                    else if (stack.Peek() > -item)
                    {
                        continue;
                    }
                    else if (stack.Peek() == -item)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        var shouldPush = true;
                        while (stack.Any())
                        {
                            var current = stack.Pop();
                            if (current > -item)
                            {
                                shouldPush = false;
                                stack.Push(current);
                                break;
                            }
                            else if (current == -item)
                            {
                                shouldPush = false;
                                break;
                            }
                            else if (current < 0)
                            {
                                stack.Push(current);
                                shouldPush = true;
                                break;
                            }
                        }

                        if (shouldPush)
                        {
                            stack.Push(item);
                        }
                    }
                }
            }


            var res = new int[stack.Count];
            for (int i = stack.Count - 1; i >=0; i--)
            {
                res[i] = stack.Pop();
            }

            return res;
        }
    }
}
