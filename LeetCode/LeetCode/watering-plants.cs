using System;
namespace LeetCode
{
    public class watering_plants
    {
        public int WateringPlants(int[] plants, int capacity)
        {
            var res = 0;
            var current = capacity;
            for (int i = 0; i < plants.Length; i++)
            {
                if (current >= plants[i])
                {
                    res++;
                    current -= plants[i];
                }
                else
                {
                    res += 2 * i + 1;
                    current = capacity - plants[i];
                }
            }

            return res;
        }
    }
}
