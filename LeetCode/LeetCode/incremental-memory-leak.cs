using System;
namespace LeetCode
{
    public class incremental_memory_leak
    {
        public int[] MemLeak(int memory1, int memory2)
        {
            var time = 1;
            while (true)
            {
				if (memory1 >= time && memory2 >= time)
				{
					if (memory1 == memory2 || memory1 > memory2)
					{
						memory1 -= time;
					}
					else
					{
						memory2 -= time;
					}
				}
				else if (memory1 >= time)
				{
					memory1 -= time;
				}
				else if (memory2 >= time)
				{
					memory2 -= time;

				}
				else
				{
					return new int[] { time, memory1, memory2 };
				}

				time++;
            }

			return new int[0];
        }
    }
}
