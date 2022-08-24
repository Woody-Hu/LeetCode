using System;
namespace LeetCode
{
    public class minimum_sideway_jumps
    {
        public int MinSideJumps(int[] obstacles)
        {
            int way = 2;
            int count = 0;
            for (int i = 1; i < obstacles.Length; i++)
            {
                if (obstacles[i] == way)
                {
                    count++;
                    if (obstacles[i - 1] != 0) 
                    {
                        way = 6 - obstacles[i - 1] - way;
                    }
                    else
                    {
                        for (int j = i + 1; j < obstacles.Length; j++)
                        {
                            if (j == obstacles.Length - 1) 
                            {
                                return count;
                            }
                            else if (obstacles[j] > 0 && obstacles[j] != way)
                            {
                                way = 6 - obstacles[j] - way;
                                i = j;
                                break;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
