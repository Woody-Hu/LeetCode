using System;
namespace LeetCode
{
    public class water_bottles
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            return numBottles >= numExchange ? (numBottles - numExchange) / (numExchange - 1) + 1 + numBottles : numBottles;
        }
    }
}
